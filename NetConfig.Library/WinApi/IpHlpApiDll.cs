using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    internal static class IpHlpApiDll
    {
        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/freemibtable">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern void FreeMibTable(nint Memory);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/getiftable2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError GetIfTable2(out nint Table);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/getifentry2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError GetIfEntry2(ref MIB_IF_ROW2 Row);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/getipinterfaceentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError GetIpInterfaceEntry(ref MIB_IPINTERFACE_ROW Row);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/getipforwardtable2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError GetIpForwardTable2(ushort Family, out nint Table);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/initializeipforwardentry">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern void InitializeIpForwardEntry(ref MIB_IPFORWARD_ROW2_IN Row);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/createipforwardentry2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError CreateIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN Row);

        /// <summary>
        /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/deleteipforwardentry2">Documentation</a>
        /// </summary>
        [DllImport("iphlpapi")]
        public static extern WinError DeleteIpForwardEntry2(ref MIB_IPFORWARD_ROW2_IN pRoute);
    }
}
