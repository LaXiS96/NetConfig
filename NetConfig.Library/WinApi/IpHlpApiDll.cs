using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    internal static class IpHlpApiDll
    {
        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-freemibtable">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern void FreeMibTable(nint Memory);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-getiftable">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIfTable(nint pIfTable, ref uint pdwSize, bool bOrder);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-getiftable2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIfTable2(out nint Table);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-getifentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIfEntry(ref MIB_IFROW pIfRow);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-getipinterfaceentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIpInterfaceEntry(ref MIB_IPINTERFACE_ROW Row);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-getipforwardtable">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIpForwardTable(nint pIpForwardTable, ref uint pdwSize, bool bOrder);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-getipforwardtable2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint GetIpForwardTable2(ADDRESS_FAMILY Family, out nint Table);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-createipforwardentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint CreateIpForwardEntry(ref MIB_IPFORWARDROW pRoute);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-createipforwardentry2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint CreateIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN Row);

        ///// <summary>
        ///// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-createipforwardentry2">Documentation</a>
        ///// </summary>
        //[DllImport("iphlpapi")]
        //public static extern uint CreateIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN6 Row);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-initializeipforwardentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern void InitializeIpForwardEntry(ref MIB_IPFORWARD_ROW2_IN Row);

        ///// <summary>
        ///// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-initializeipforwardentry">Documentation</a>
        ///// </summary>
        //[DllImport("iphlpapi")]
        //public static extern void InitializeIpForwardEntry(ref MIB_IPFORWARD_ROW2_IN6 Row);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-setipforwardentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint SetIpForwardEntry(ref MIB_IPFORWARDROW pRoute);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/iphlpapi/nf-iphlpapi-deleteipforwardentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint DeleteIpForwardEntry(ref MIB_IPFORWARDROW pRoute);

        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-deleteipforwardentry2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern uint DeleteIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN pRoute);

        ///// <summary>
        ///// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/nf-netioapi-deleteipforwardentry2">Documentation</a>
        ///// </summary>
        //[DllImport("iphlpapi")]
        //public static extern uint DeleteIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN6 pRoute);
    }
}
