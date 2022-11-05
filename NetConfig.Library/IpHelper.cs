using LaXiS.NetConfig.Library.WinApi;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library
{
    public static class IpHelper
    {
        public static List<Interface> GetInterfaces()
        {
            IpHlpApiDll.GetIfTable2(out nint tablePtr).ThrowIfError();

            var table = Marshal.PtrToStructure<MIB_IF_TABLE2>(tablePtr);
            var rowPtr = tablePtr + Marshal.OffsetOf<MIB_IF_TABLE2>(nameof(MIB_IF_TABLE2.Table));
            var interfaces = new List<Interface>();
            for (var i = 0; i < table.NumEntries; i++)
            {
                var row = Marshal.PtrToStructure<MIB_IF_ROW2>(rowPtr);
                interfaces.Add(Interface.From(row));
                rowPtr += Marshal.SizeOf<MIB_IF_ROW2>();
            }

            IpHlpApiDll.FreeMibTable(tablePtr);

            return interfaces;
        }

        public static List<Route> GetRoutes(AddressFamily family)
        {
            IpHlpApiDll.GetIpForwardTable2((ushort)family, out nint tablePtr).ThrowIfError();

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
    }
}
