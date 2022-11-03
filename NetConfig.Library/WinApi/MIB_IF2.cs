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
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IFDEF.IF_MAX_STRING_SIZE + 1)]
        public string Alias;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IFDEF.IF_MAX_STRING_SIZE + 1)]
        public string Description;
        public uint PhysicalAddressLength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = IFDEF.IF_MAX_PHYS_ADDRESS_LENGTH)]
        public byte[] PhysicalAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = IFDEF.IF_MAX_PHYS_ADDRESS_LENGTH)]
        public byte[] PermanentPhysicalAddress;
        public uint Mtu;
        public InterfaceType Type;
        public InterfaceTunnelType TunnelType;
        public InterfaceMediumType MediaType;
        public InterfacePhysicalMediumType PhysicalMediumType;
        public InterfaceAccessType AccessType;
        public InterfaceDirectionType DirectionType;
        public InterfaceFlags InterfaceAndOperStatusFlags;
        public InterfaceOperStatus OperStatus;
        public InterfaceAdminStatus AdminStatus;
        public InterfaceMediaConnectState MediaConnectState;
        public Guid NetworkGuid;
        public InterfaceConnectionType ConnectionType;
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
}
