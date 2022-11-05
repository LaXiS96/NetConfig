using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// <a href="https://learn.microsoft.com/en-us/windows-hardware/drivers/network/mib-ipinterface-row">Documentation</a>
    /// </summary>
    internal struct MIB_IPINTERFACE_ROW
    {
        public ushort Family;
        public ulong InterfaceLuid;
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
        public RouterDiscoveryBehavior RouterDiscoveryBehavior;
        public uint DadTransmits;
        public uint BaseReachableTime;
        public uint RetransmitTime;
        public uint PathMtuDiscoveryTimeout;
        public LinkLocalAddressBehavior LinkLocalAddressBehavior;
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
        public InterfaceOffloadFlags TransmitOffload;
        public InterfaceOffloadFlags ReceiveOffload;
        [MarshalAs(UnmanagedType.U1)] public bool DisableDefaultRoutes;
    }
}
