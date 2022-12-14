namespace LaXiS.NetConfig.Library
{
    /// <summary>
    /// IFTYPE
    /// </summary>
    public enum InterfaceType
    {
        OTHER = 1,
        REGULAR_1822 = 2,
        HDH_1822 = 3,
        DDN_X25 = 4,
        RFC877_X25 = 5,
        ETHERNET_CSMACD = 6,
        IS088023_CSMACD = 7,
        ISO88024_TOKENBUS = 8,
        ISO88025_TOKENRING = 9,
        ISO88026_MAN = 10,
        STARLAN = 11,
        PROTEON_10MBIT = 12,
        PROTEON_80MBIT = 13,
        HYPERCHANNEL = 14,
        FDDI = 15,
        LAP_B = 16,
        SDLC = 17,
        DS1 = 18,
        E1 = 19,
        BASIC_ISDN = 20,
        PRIMARY_ISDN = 21,
        PROP_POINT2POINT_SERIAL = 22,
        PPP = 23,
        SOFTWARE_LOOPBACK = 24,
        EON = 25,
        ETHERNET_3MBIT = 26,
        NSIP = 27,
        SLIP = 28,
        ULTRA = 29,
        DS3 = 30,
        SIP = 31,
        FRAMERELAY = 32,
        RS232 = 33,
        PARA = 34,
        ARCNET = 35,
        ARCNET_PLUS = 36,
        ATM = 37,
        MIO_X25 = 38,
        SONET = 39,
        X25_PLE = 40,
        ISO88022_LLC = 41,
        LOCALTALK = 42,
        SMDS_DXI = 43,
        FRAMERELAY_SERVICE = 44,
        V35 = 45,
        HSSI = 46,
        HIPPI = 47,
        MODEM = 48,
        AAL5 = 49,
        SONET_PATH = 50,
        SONET_VT = 51,
        SMDS_ICIP = 52,
        PROP_VIRTUAL = 53,
        PROP_MULTIPLEXOR = 54,
        IEEE80212 = 55,
        FIBRECHANNEL = 56,
        HIPPIINTERFACE = 57,
        FRAMERELAY_INTERCONNECT = 58,
        AFLANE_8023 = 59,
        AFLANE_8025 = 60,
        CCTEMUL = 61,
        FASTETHER = 62,
        ISDN = 63,
        V11 = 64,
        V36 = 65,
        G703_64K = 66,
        G703_2MB = 67,
        QLLC = 68,
        FASTETHER_FX = 69,
        CHANNEL = 70,
        IEEE80211 = 71,
        IBM370PARCHAN = 72,
        ESCON = 73,
        DLSW = 74,
        ISDN_S = 75,
        ISDN_U = 76,
        LAP_D = 77,
        IPSWITCH = 78,
        RSRB = 79,
        ATM_LOGICAL = 80,
        DS0 = 81,
        DS0_BUNDLE = 82,
        BSC = 83,
        ASYNC = 84,
        CNR = 85,
        ISO88025R_DTR = 86,
        EPLRS = 87,
        ARAP = 88,
        PROP_CNLS = 89,
        HOSTPAD = 90,
        TERMPAD = 91,
        FRAMERELAY_MPI = 92,
        X213 = 93,
        ADSL = 94,
        RADSL = 95,
        SDSL = 96,
        VDSL = 97,
        ISO88025_CRFPRINT = 98,
        MYRINET = 99,
        VOICE_EM = 100,
        VOICE_FXO = 101,
        VOICE_FXS = 102,
        VOICE_ENCAP = 103,
        VOICE_OVERIP = 104,
        ATM_DXI = 105,
        ATM_FUNI = 106,
        ATM_IMA = 107,
        PPPMULTILINKBUNDLE = 108,
        IPOVER_CDLC = 109,
        IPOVER_CLAW = 110,
        STACKTOSTACK = 111,
        VIRTUALIPADDRESS = 112,
        MPC = 113,
        IPOVER_ATM = 114,
        ISO88025_FIBER = 115,
        TDLC = 116,
        GIGABITETHERNET = 117,
        HDLC = 118,
        LAP_F = 119,
        V37 = 120,
        X25_MLP = 121,
        X25_HUNTGROUP = 122,
        TRANSPHDLC = 123,
        INTERLEAVE = 124,
        FAST = 125,
        IP = 126,
        DOCSCABLE_MACLAYER = 127,
        DOCSCABLE_DOWNSTREAM = 128,
        DOCSCABLE_UPSTREAM = 129,
        A12MPPSWITCH = 130,
        TUNNEL = 131,
        COFFEE = 132,
        CES = 133,
        ATM_SUBINTERFACE = 134,
        L2_VLAN = 135,
        L3_IPVLAN = 136,
        L3_IPXVLAN = 137,
        DIGITALPOWERLINE = 138,
        MEDIAMAILOVERIP = 139,
        DTM = 140,
        DCN = 141,
        IPFORWARD = 142,
        MSDSL = 143,
        IEEE1394 = 144,
        IF_GSN = 145,
        DVBRCC_MACLAYER = 146,
        DVBRCC_DOWNSTREAM = 147,
        DVBRCC_UPSTREAM = 148,
        ATM_VIRTUAL = 149,
        MPLS_TUNNEL = 150,
        SRP = 151,
        VOICEOVERATM = 152,
        VOICEOVERFRAMERELAY = 153,
        IDSL = 154,
        COMPOSITELINK = 155,
        SS7_SIGLINK = 156,
        PROP_WIRELESS_P2P = 157,
        FR_FORWARD = 158,
        RFC1483 = 159,
        USB = 160,
        IEEE8023AD_LAG = 161,
        BGP_POLICY_ACCOUNTING = 162,
        FRF16_MFR_BUNDLE = 163,
        H323_GATEKEEPER = 164,
        H323_PROXY = 165,
        MPLS = 166,
        MF_SIGLINK = 167,
        HDSL2 = 168,
        SHDSL = 169,
        DS1_FDL = 170,
        POS = 171,
        DVB_ASI_IN = 172,
        DVB_ASI_OUT = 173,
        PLC = 174,
        NFAS = 175,
        TR008 = 176,
        GR303_RDT = 177,
        GR303_IDT = 178,
        ISUP = 179,
        PROP_DOCS_WIRELESS_MACLAYER = 180,
        PROP_DOCS_WIRELESS_DOWNSTREAM = 181,
        PROP_DOCS_WIRELESS_UPSTREAM = 182,
        HIPERLAN2 = 183,
        PROP_BWA_P2MP = 184,
        SONET_OVERHEAD_CHANNEL = 185,
        DIGITAL_WRAPPER_OVERHEAD_CHANNEL = 186,
        AAL2 = 187,
        RADIO_MAC = 188,
        ATM_RADIO = 189,
        IMT = 190,
        MVL = 191,
        REACH_DSL = 192,
        FR_DLCI_ENDPT = 193,
        ATM_VCI_ENDPT = 194,
        OPTICAL_CHANNEL = 195,
        OPTICAL_TRANSPORT = 196,
        IEEE80216_WMAN = 237,
        WWANPP = 243,
        WWANPP2 = 244,
        IEEE802154 = 259,
        XBOX_WIRELESS = 281,
    }

    /// <summary>
    /// TUNNEL_TYPE
    /// </summary>
    public enum InterfaceTunnelType
    {
        None = 0,
        Other = 1,
        Direct = 2,
        _6To4 = 11,
        Isatap = 13,
        Teredo = 14,
        IpHttps = 15,
    }

    /// <summary>
    /// NDIS_MEDIUM
    /// </summary>
    public enum InterfaceMediumType
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

    /// <summary>
    /// NDIS_PHYSICAL_MEDIUM
    /// </summary>
    public enum InterfacePhysicalMediumType
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

    /// <summary>
    /// NET_IF_ACCESS_TYPE
    /// </summary>
    public enum InterfaceAccessType
    {
        Loopback = 1,
        Broadcast = 2,
        PointToPoint = 3,
        PointToMultiPoint = 4,
    }

    /// <summary>
    /// NET_IF_DIRECTION_TYPE
    /// </summary>
    public enum InterfaceDirectionType
    {
        SendReceive,
        SendOnly,
        ReceiveOnly,
    }

    /// <summary>
    /// InterfaceAndOperStatusFlags
    /// </summary>
    [Flags]
    public enum InterfaceFlags : byte
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

    /// <summary>
    /// IF_OPER_STATUS
    /// </summary>
    public enum InterfaceOperStatus
    {
        Up = 1,
        Down,
        Testing,
        Unknown,
        Dormant,
        NotPresent,
        LowerLayerDown,
    }

    /// <summary>
    /// NET_IF_ADMIN_STATUS
    /// </summary>
    public enum InterfaceAdminStatus
    {
        Up = 1,
        Down = 2,
        Testing = 3,
    }

    /// <summary>
    /// NET_IF_MEDIA_CONNECT_STATE
    /// </summary>
    public enum InterfaceMediaConnectState
    {
        Unknown,
        Connected,
        Disconnected,
    }

    /// <summary>
    /// NET_IF_CONNECTION_TYPE
    /// </summary>
    public enum InterfaceConnectionType
    {
        Dedicated = 1,
        Passive = 2,
        Demand = 3,
    }

    /// <summary>
    /// NL_ROUTER_DISCOVERY_BEHAVIOR
    /// </summary>
    public enum RouterDiscoveryBehavior
    {
        Disabled = 0,
        Enabled,
        Dhcp,
        Unchanged = -1
    }

    /// <summary>
    /// NL_LINK_LOCAL_ADDRESS_BEHAVIOR
    /// </summary>
    public enum LinkLocalAddressBehavior
    {
        AlwaysOff = 0,
        Delayed,
        AlwaysOn,
        Unchanged = -1
    }

    /// <summary>
    /// NL_INTERFACE_OFFLOAD_ROD
    /// </summary>
    [Flags]
    public enum InterfaceOffloadFlags : byte
    {
        NlChecksumSupported = 0x1,
        NlOptionsSupported = 0x2,
        TlDatagramChecksumSupported = 0x4,
        TlStreamChecksumSupported = 0x8,
        TlStreamOptionsSupported = 0x10,
        FastPathCompatible = 0x20,
        TlLargeSendOffloadSupported = 0x40,
        TlGiantSendOffloadSupported = 0x80,
    }
}
