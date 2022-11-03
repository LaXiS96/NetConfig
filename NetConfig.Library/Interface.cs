using LaXiS.NetConfig.Library.WinApi;

namespace LaXiS.NetConfig.Library
{
    public class Interface
    {
        public long Luid { get; }
        public int Index { get; }
        public Guid Guid { get; }
        public string Name { get; }
        public string Description { get; }
        public byte[] PhysicalAddress { get; }
        public byte[] PermanentPhysicalAddress { get; }
        public int Mtu { get; }
        public InterfaceType Type { get; }
        public InterfaceTunnelType TunnelType { get; }
        public InterfaceMediumType MediaType { get; }
        public InterfacePhysicalMediumType PhysicalMediumType { get; }
        public InterfaceAccessType AccessType { get; }
        public InterfaceDirectionType DirectionType { get; }
        public InterfaceFlags Flags { get; }
        public InterfaceOperStatus OperStatus { get; }
        public InterfaceAdminStatus AdminStatus { get; }
        public InterfaceMediaConnectState MediaConnectState { get; }
        public Guid NetworkGuid { get; }
        public InterfaceConnectionType ConnectionType { get; }
        public long TransmitLinkSpeed { get; }
        public long ReceiveLinkSpeed { get; }
        public long InBytes { get; }
        public long InUnicastPackets { get; }
        public long InOtherPackets { get; }
        public long InDiscards { get; }
        public long InErrors { get; }
        public long InUnknownPackets { get; }
        public long InUnicastBytes { get; }
        public long InMulticastBytes { get; }
        public long InBroadcastBytes { get; }
        public long OutBytes { get; }
        public long OutUnicastPackets { get; }
        public long OutOtherPackets { get; }
        public long OutDiscards { get; }
        public long OutErrors { get; }
        public long OutUnicastBytes { get; }
        public long OutMulticastBytes { get; }
        public long OutBroadcastBytes { get; }
        public long OutQueueLength { get; }

        internal Interface(MIB_IF_ROW2 row)
        {
            Luid = (long)row.InterfaceLuid;
            Index = (int)row.InterfaceIndex;
            Guid = row.InterfaceGuid;
            Name = row.Alias;
            Description = row.Description;

            PhysicalAddress = new byte[row.PhysicalAddressLength];
            Array.Copy(row.PhysicalAddress, PhysicalAddress, PhysicalAddress.Length);

            PermanentPhysicalAddress = new byte[row.PhysicalAddressLength];
            Array.Copy(row.PermanentPhysicalAddress, PermanentPhysicalAddress, PermanentPhysicalAddress.Length);

            Mtu = (int)row.Mtu;
            Type = row.Type;
            TunnelType = row.TunnelType;
            MediaType = row.MediaType;
            PhysicalMediumType = row.PhysicalMediumType;
            AccessType = row.AccessType;
            DirectionType = row.DirectionType;
            Flags = row.InterfaceAndOperStatusFlags;
            OperStatus = row.OperStatus;
            AdminStatus = row.AdminStatus;
            MediaConnectState = row.MediaConnectState;
            NetworkGuid = row.NetworkGuid;
            ConnectionType = row.ConnectionType;
            TransmitLinkSpeed = (long)row.TransmitLinkSpeed;
            ReceiveLinkSpeed = (long)row.ReceiveLinkSpeed;
            InBytes = (long)row.InOctets;
            InUnicastPackets = (long)row.InUcastPkts;
            InOtherPackets = (long)row.InNUcastPkts;
            InDiscards = (long)row.InDiscards;
            InErrors = (long)row.InErrors;
            InUnknownPackets = (long)row.InUnknownProtos;
            InUnicastBytes = (long)row.InUcastOctets;
            InMulticastBytes = (long)row.InMulticastOctets;
            InBroadcastBytes = (long)row.InBroadcastOctets;
            OutBytes = (long)row.OutOctets;
            OutUnicastPackets = (long)row.OutUcastPkts;
            OutOtherPackets = (long)row.OutNUcastPkts;
            OutDiscards = (long)row.OutDiscards;
            OutErrors = (long)row.OutErrors;
            OutUnicastBytes = (long)row.OutUcastOctets;
            OutMulticastBytes = (long)row.OutMulticastOctets;
            OutBroadcastBytes = (long)row.OutBroadcastOctets;
            OutQueueLength = (long)row.OutQLen;
        }
    }
}
