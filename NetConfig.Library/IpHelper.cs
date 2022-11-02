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

            //uint error;
            //nint tablePtr = 0;
            //uint size = 0;

            //error = IpHlpApiDll.GetIfTable(tablePtr, ref size, true);
            //if (error != WinError.NO_ERROR && error != WinError.INSUFFICIENT_BUFFER)
            //    throw new WinApiException(error);

            //tablePtr = Marshal.AllocHGlobal((int)size);
            //error = IpHlpApiDll.GetIfTable(tablePtr, ref size, true);
            //if (error != WinError.NO_ERROR)
            //    throw new WinApiException(error);

            //var table = Marshal.PtrToStructure<MIB_IFTABLE>(tablePtr);

            //var interfaces = new List<Interface>();
            //var rowPtr = tablePtr + Marshal.SizeOf(table.dwNumEntries);
            //for (int i = 0; i < table.dwNumEntries; i++)
            //{
            //    var row = Marshal.PtrToStructure<MIB_IFROW>(rowPtr);
            //    interfaces.Add(new Interface(row));

            //    rowPtr += Marshal.SizeOf<MIB_IFROW>();
            //}

            //Marshal.FreeHGlobal(tablePtr);

            //return interfaces;
        }

        public static Interface GetInterface(int index)
        {
            var row = new MIB_IFROW()
            {
                dwIndex = (uint)index
            };

            var error = IpHlpApiDll.GetIfEntry(ref row);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);

            return new Interface(row);
        }

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

            //uint error;
            //nint tablePtr = 0;
            //uint size = 0;

            //error = IpHlpApiDll.GetIpForwardTable(tablePtr, ref size, true);
            //if (error != WinError.NO_ERROR && error != WinError.INSUFFICIENT_BUFFER)
            //    throw new WinApiException(error);

            //tablePtr = Marshal.AllocHGlobal((int)size);
            //error = IpHlpApiDll.GetIpForwardTable(tablePtr, ref size, true);
            //if (error != WinError.NO_ERROR)
            //    throw new WinApiException(error);

            //var table = Marshal.PtrToStructure<MIB_IPFORWARDTABLE>(tablePtr);

            //var routes = new List<Route>();
            //var rowPtr = tablePtr + Marshal.SizeOf(table.dwNumEntries);
            //for (int i = 0; i < table.dwNumEntries; i++)
            //{
            //    var row = Marshal.PtrToStructure<MIB_IPFORWARDROW>(rowPtr);
            //    routes.Add(new Route(row));

            //    rowPtr += Marshal.SizeOf<MIB_IPFORWARDROW>();
            //}

            //Marshal.FreeHGlobal(tablePtr);

            //return routes;
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

            //var row = new MIB_IPFORWARDROW
            //{
            //    dwForwardProto = MIB_IPFORWARD_PROTO.NETMGMT,
            //    dwForwardIfIndex = (uint)interfaceIndex,
            //    dwForwardDest = BitConverter.ToUInt32(destination.GetAddressBytes()),
            //    dwForwardMask = BitConverter.ToUInt32(mask.GetAddressBytes()),
            //    dwForwardNextHop = BitConverter.ToUInt32(nextHop.GetAddressBytes()),
            //    dwForwardMetric1 = (uint)metric // TODO see docs
            //};

            //var error = IpHlpApiDll.CreateIpForwardEntry(ref row);
            //if (error != WinError.NO_ERROR)
            //    throw new WinApiException(error);
        }

        public static void RemoveRoute(int interfaceIndex, IPAddress destination, IPAddress mask, IPAddress nextHop)
        {
            var row = new MIB_IPFORWARDROW
            {
                dwForwardProto = MIB_IPFORWARD_PROTO.NETMGMT,
                dwForwardIfIndex = (uint)interfaceIndex,
                dwForwardDest = BitConverter.ToUInt32(destination.GetAddressBytes()),
                dwForwardMask = BitConverter.ToUInt32(mask.GetAddressBytes()),
                dwForwardNextHop = BitConverter.ToUInt32(nextHop.GetAddressBytes()),
            };

            var error = IpHlpApiDll.DeleteIpForwardEntry(ref row);
            if (error != WinError.NO_ERROR)
                throw new WinApiException(error);
        }
    }
}
