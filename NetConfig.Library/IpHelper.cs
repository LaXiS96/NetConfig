using LaXiS.NetConfig.Library.WinApi;
using System.Net;
using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library
{
    public static class IpHelper
    {
        public static List<Interface> GetInterfaces()
        {
            var error = IpHlpApiDll.GetIfTable2(out nint tablePtr);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);

            var table = Marshal.PtrToStructure<MIB_IF_TABLE2>(tablePtr);
            var rowPtr = tablePtr + Marshal.OffsetOf<MIB_IF_TABLE2>(nameof(MIB_IF_TABLE2.Table));
            var interfaces = new List<Interface>();
            for (var i = 0; i < table.NumEntries; i++)
            {
                var row = Marshal.PtrToStructure<MIB_IF_ROW2>(rowPtr);
                interfaces.Add(new Interface(row));
                rowPtr += Marshal.SizeOf<MIB_IF_ROW2>();
            }

            IpHlpApiDll.FreeMibTable(tablePtr);

            return interfaces;
        }

        private static Interface GetInterfaceInternal(int? index, long? luid)
        {
            var row = new MIB_IF_ROW2();

            if (index is not null)
                row.InterfaceIndex = (uint)index;

            if (luid is not null)
                row.InterfaceLuid = (ulong)luid;

            var error = IpHlpApiDll.GetIfEntry2(ref row);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);

            return new Interface(row);
        }

        public static Interface GetInterface(int index)
            => GetInterfaceInternal(index, default);

        public static Interface GetInterface(long luid)
            => GetInterfaceInternal(default, luid);

        public static void GetInterfaceInfo(int index)
        {
            var row = new MIB_IPINTERFACE_ROW
            {
                Family = ADDRESS_FAMILY.AF_INET,
                InterfaceIndex = (uint)index,
            };

            var error = IpHlpApiDll.GetIpInterfaceEntry(ref row);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);

            // TODO
        }

        public static List<Route> GetRoutes()
        {
            var error = IpHlpApiDll.GetIpForwardTable2(ADDRESS_FAMILY.AF_INET, out nint tablePtr);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);

            var table = Marshal.PtrToStructure<MIB_IPFORWARD_TABLE2>(tablePtr);
            var rowPtr = tablePtr + Marshal.OffsetOf<MIB_IPFORWARD_TABLE2>(nameof(MIB_IPFORWARD_TABLE2.Table));
            var routes = new List<Route>();
            for (var i = 0; i < table.NumEntries; i++)
            {
                var row = Marshal.PtrToStructure<MIB_IPFORWARD_ROW2_IN>(rowPtr);
                routes.Add(new Route(row));
                rowPtr += Marshal.SizeOf<MIB_IPFORWARD_ROW2_IN>();
            }

            IpHlpApiDll.FreeMibTable(tablePtr);

            return routes;
        }

        public static void AddRoute(int interfaceIndex, IPAddress destination, IPAddress mask, IPAddress nextHop, int metric)
        {
            var row = new MIB_IPFORWARD_ROW2_IN();
            IpHlpApiDll.InitializeIpForwardEntry(ref row);

            row.DestinationPrefix.Prefix = (SOCKADDR_IN)destination;
            row.DestinationPrefix.PrefixLength = mask.GetCidrMaskLength();
            row.NextHop = (SOCKADDR_IN)nextHop;
            row.InterfaceIndex = (uint)interfaceIndex;

            var error = IpHlpApiDll.CreateIpForwardEntry2(ref row);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);
        }

        public static void RemoveRoute(int interfaceIndex, IPAddress destination, IPAddress mask, IPAddress nextHop)
        {
            // TODO convert to version 2

            //var row = new MIB_IPFORWARDROW
            //{
            //    dwForwardProto = MIB_IPFORWARD_PROTO.NETMGMT,
            //    dwForwardIfIndex = (uint)interfaceIndex,
            //    dwForwardDest = BitConverter.ToUInt32(destination.GetAddressBytes()),
            //    dwForwardMask = BitConverter.ToUInt32(mask.GetAddressBytes()),
            //    dwForwardNextHop = BitConverter.ToUInt32(nextHop.GetAddressBytes()),
            //};

            //var error = IpHlpApiDll.DeleteIpForwardEntry(ref row);
            //if (error != WinError.NO_ERROR)
            //    throw new WinApiException(error);
        }
    }
}
