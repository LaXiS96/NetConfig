using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_ipinterface_row">Documentation</a>
    /// </summary>
    internal struct MIB_IPINTERFACE_ROW
    {
        public ADDRESS_FAMILY Family;
        public ulong InterfaceLuid; // TODO struct
        public uint InterfaceIndex;
        public uint MaxReassemblySize;
        public ulong InterfaceIdentifier;
        public uint MinRouterAdvertisementInterval;
        public uint MaxRouterAdvertisementInterval;
        [MarshalAs(UnmanagedType.U1)] public bool AdvertisingEnabled;
        [MarshalAs(UnmanagedType.U1)] public bool ForwardingEnabled;
        [MarshalAs(UnmanagedType.U1)] public bool WeakHostSend;
        [MarshalAs(UnmanagedType.U1)] public bool WeakHostReceive;
        [MarshalAs(UnmanagedType.U1)] public bool UseAutomaticMetric;
        [MarshalAs(UnmanagedType.U1)] public bool UseNeighborUnreachabilityDetection;
        [MarshalAs(UnmanagedType.U1)] public bool ManagedAddressConfigurationSupported;
        [MarshalAs(UnmanagedType.U1)] public bool OtherStatefulConfigurationSupported;
        [MarshalAs(UnmanagedType.U1)] public bool AdvertiseDefaultRoute;
        public int RouterDiscoveryBehavior; // TODO enum
        public uint DadTransmits;
        public uint BaseReachableTime;
        public uint RetransmitTime;
        public uint PathMtuDiscoveryTimeout;
        public int LinkLocalAddressBehavior; // TODO enum
        public uint LinkLocalAddressTimeout;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public uint[] ZoneIndices;
        public uint SitePrefixLength;
        public uint Metric;
        public uint NlMtu;
        [MarshalAs(UnmanagedType.U1)] public bool Connected;
        [MarshalAs(UnmanagedType.U1)] public bool SupportsWakeUpPatterns;
        [MarshalAs(UnmanagedType.U1)] public bool SupportsNeighborDiscovery;
        [MarshalAs(UnmanagedType.U1)] public bool SupportsRouterDiscovery;
        public uint ReachableTime;
        public int TransmitOffload; // TODO bitfield struct
        public int ReceiveOffload; // TODO bitfield struct
        [MarshalAs(UnmanagedType.U1)] public bool DisableDefaultRoutes;
    }
}
