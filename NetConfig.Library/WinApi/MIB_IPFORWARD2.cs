using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_ipforward_table2">Documentation</a>
    /// </summary>
    internal struct MIB_IPFORWARD_TABLE2
    {
        public uint NumEntries;
        public nint Table;
    }

    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_ipforward_row2">Documentation</a>
    /// </summary>
    internal struct MIB_IPFORWARD_ROW2_IN
    {
        public ulong InterfaceLuid;
        public uint InterfaceIndex;
        public IP_ADDRESS_PREFIX<SOCKADDR_IN> DestinationPrefix;
        public SOCKADDR_IN NextHop;
        public byte SitePrefixLength;
        public uint ValidLifetime;
        public uint PreferredLifetime;
        public uint Metric;
        public RouteProtocol Protocol;
        [MarshalAs(UnmanagedType.U1)] public bool Loopback;
        [MarshalAs(UnmanagedType.U1)] public bool AutoconfigureAddress;
        [MarshalAs(UnmanagedType.U1)] public bool Publish;
        [MarshalAs(UnmanagedType.U1)] public bool Immortal;
        public uint Age;
        public RouteOrigin Origin;
    }

    ///// <summary>
    ///// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_ipforward_row2">Documentation</a>
    ///// </summary>
    //internal struct MIB_IPFORWARD_ROW2_IN6
    //{
    //    public ulong InterfaceLuid;
    //    public uint InterfaceIndex;
    //    public IP_ADDRESS_PREFIX<SOCKADDR_IN6> DestinationPrefix;
    //    public SOCKADDR_IN6 NextHop;
    //    public byte SitePrefixLength;
    //    public uint ValidLifetime;
    //    public uint PreferredLifetime;
    //    public uint Metric;
    //    public int Protocol; // TODO NL_ROUTE_PROTOCOL enum
    //    [MarshalAs(UnmanagedType.U1)] public bool Loopback;
    //    [MarshalAs(UnmanagedType.U1)] public bool AutoconfigureAddress;
    //    [MarshalAs(UnmanagedType.U1)] public bool Publish;
    //    [MarshalAs(UnmanagedType.U1)] public bool Immortal;
    //    public uint Age;
    //    public int Origin; // TODO NL_ROUTE_ORIGIN enum
    //}
}
