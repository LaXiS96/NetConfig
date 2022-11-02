namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/ipmib/ns-ipmib-mib_ipforwardtable">Documentation</a>
    /// </summary>
    internal struct MIB_IPFORWARDTABLE
    {
        public int dwNumEntries;
        public nint table;
    }

    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/ipmib/ns-ipmib-mib_ipforwardrow">Documentation</a>
    /// </summary>
    internal struct MIB_IPFORWARDROW
    {
        public uint dwForwardDest;
        public uint dwForwardMask;
        public uint dwForwardPolicy;
        public uint dwForwardNextHop;
        public uint dwForwardIfIndex;
        public MIB_IPFORWARD_TYPE dwForwardType;
        public MIB_IPFORWARD_PROTO dwForwardProto;
        public uint dwForwardAge;
        public uint dwForwardNextHopAS;
        public uint dwForwardMetric1;
        public uint dwForwardMetric2;
        public uint dwForwardMetric3;
        public uint dwForwardMetric4;
        public uint dwForwardMetric5;
    }

    internal enum MIB_IPFORWARD_TYPE : uint
    {
        OTHER = 1,
        INVALID = 2,
        DIRECT = 3,
        INDIRECT = 4,
    }

    internal enum MIB_IPFORWARD_PROTO : uint
    {
        OTHER = 1,
        LOCAL = 2,
        NETMGMT = 3,
        ICMP = 4,
        EGP = 5,
        GGP = 6,
        HELLO = 7,
        RIP = 8,
        IS_IS = 9,
        ES_IS = 10,
        CISCO = 11,
        BBN = 12,
        OSPF = 13,
        BGP = 14,
        NT_AUTOSTATIC = 10002,
        NT_STATIC = 10006,
        NT_STATIC_NON_DOD = 10007,
    }
}
