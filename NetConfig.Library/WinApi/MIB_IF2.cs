using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_if_table2">Documentation</a>
    /// </summary>
    internal struct MIB_IF_TABLE2
    {
        public uint NumEntries;
        public nint Table;
    }

    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/netioapi/ns-netioapi-mib_if_row2">Documentation</a>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct MIB_IF_ROW2
    {
        public ulong InterfaceLuid;
        public uint InterfaceIndex;
        public Guid InterfaceGuid;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)] public string Alias;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)] public string Description;
        public uint PhysicalAddressLength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte[] PhysicalAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte[] PermanentPhysicalAddress;
        public uint Mtu;
        public IFTYPE Type;
        public TUNNEL_TYPE TunnelType;
        public NDIS_MEDIUM MediaType;
        public NDIS_PHYSICAL_MEDIUM PhysicalMediumType;
        public NET_IF_ACCESS_TYPE AccessType;
        public NET_IF_DIRECTION_TYPE DirectionType;
        public InterfaceAndOperStatusFlags InterfaceAndOperStatusFlags;
        public IF_OPER_STATUS OperStatus;
        public NET_IF_ADMIN_STATUS AdminStatus;
        public NET_IF_MEDIA_CONNECT_STATE MediaConnectState;
        public Guid NetworkGuid;
        public NET_IF_CONNECTION_TYPE ConnectionType;
        public ulong TransmitLinkSpeed;
        public ulong ReceiveLinkSpeed;
        public ulong InOctets;
        public ulong InUcastPkts;
        public ulong InNUcastPkts;
        public ulong InDiscards;
        public ulong InErrors;
        public ulong InUnknownProtos;
        public ulong InUcastOctets;
        public ulong InMulticastOctets;
        public ulong InBroadcastOctets;
        public ulong OutOctets;
        public ulong OutUcastPkts;
        public ulong OutNUcastPkts;
        public ulong OutDiscards;
        public ulong OutErrors;
        public ulong OutUcastOctets;
        public ulong OutMulticastOctets;
        public ulong OutBroadcastOctets;
        public ulong OutQLen;
    }

    internal enum TUNNEL_TYPE
    {
        NONE = 0,
        OTHER = 1,
        DIRECT = 2,
        _6TO4 = 11,
        ISATAP = 13,
        TEREDO = 14,
        IPHTTPS = 15,
    }

    internal enum NDIS_MEDIUM
    {
        _802_3,
        _802_5,
        Fddi,
        Wan,
        LocalTalk,
        Dix,
        ArcnetRaw,
        Arcnet878_2,
        Atm,
        WirelessWan,
        Irda,
        Bpc,
        CoWan,
        _1394,
        InfiniBand,
        Tunnel,
        Native802_11,
        Loopback,
        WiMAX,
        IP,
    }

    internal enum NDIS_PHYSICAL_MEDIUM
    {
        Unspecified,
        WirelessLan,
        CableModem,
        PhoneLine,
        PowerLine,
        DSL,
        FibreChannel,
        _1394,
        WirelessWan,
        Native802_11,
        Bluetooth,
        Infiniband,
        WiMax,
        UWB,
        _802_3,
        _802_5,
        Irda,
        WiredWAN,
        WiredCoWan,
        Other,
        Native802_15_4,
    }

    internal enum NET_IF_ACCESS_TYPE
    {
        LOOPBACK = 1,
        BROADCAST = 2,
        POINT_TO_POINT = 3,
        POINT_TO_MULTI_POINT = 4,
    }

    internal enum NET_IF_DIRECTION_TYPE
    {
        SENDRECEIVE,
        SENDONLY,
        RECEIVEONLY,
    }

    internal enum IF_OPER_STATUS
    {
        Up = 1,
        Down,
        Testing,
        Unknown,
        Dormant,
        NotPresent,
        LowerLayerDown,
    }

    internal enum NET_IF_ADMIN_STATUS
    {
        UP = 1,
        DOWN = 2,
        TESTING = 3,
    }

    internal enum NET_IF_MEDIA_CONNECT_STATE
    {
        Unknown,
        Connected,
        Disconnected,
    }

    internal enum NET_IF_CONNECTION_TYPE
    {
        DEDICATED = 1,
        PASSIVE = 2,
        DEMAND = 3,
    }

    [Flags]
    internal enum InterfaceAndOperStatusFlags : byte
    {
        HardwareInterface = 0x1,
        FilterInterface = 0x2,
        ConnectorPresent = 0x4,
        NotAuthenticated = 0x8,
        NotMediaConnected = 0x10,
        Paused = 0x20,
        LowPower = 0x40,
        EndPointInterface = 0x80,
    }
}
