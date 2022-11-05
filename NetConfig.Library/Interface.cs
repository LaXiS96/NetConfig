using LaXiS.NetConfig.Library.WinApi;
using System.Net;

namespace LaXiS.NetConfig.Library
{
    public class Interface
    {
        public long Luid { get; private set; }
        public int Index { get; private set; }
        public Guid Guid { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public byte[] PhysicalAddress { get; private set; }
        public byte[] PermanentPhysicalAddress { get; private set; }
        public int Mtu { get; private set; }
        public InterfaceType Type { get; private set; }
        public InterfaceTunnelType TunnelType { get; private set; }
        public InterfaceMediumType MediaType { get; private set; }
        public InterfacePhysicalMediumType PhysicalMediumType { get; private set; }
        public InterfaceAccessType AccessType { get; private set; }
        public InterfaceDirectionType DirectionType { get; private set; }
        public InterfaceFlags Flags { get; private set; }
        public InterfaceOperStatus OperStatus { get; private set; }
        public InterfaceAdminStatus AdminStatus { get; private set; }
        public InterfaceMediaConnectState MediaConnectState { get; private set; }
        public Guid NetworkGuid { get; private set; }
        public InterfaceConnectionType ConnectionType { get; private set; }
        public long TransmitLinkSpeed { get; private set; }
        public long ReceiveLinkSpeed { get; private set; }
        public long InBytes { get; private set; }
        public long InUnicastPackets { get; private set; }
        public long InOtherPackets { get; private set; }
        public long InDiscards { get; private set; }
        public long InErrors { get; private set; }
        public long InUnknownPackets { get; private set; }
        public long InUnicastBytes { get; private set; }
        public long InMulticastBytes { get; private set; }
        public long InBroadcastBytes { get; private set; }
        public long OutBytes { get; private set; }
        public long OutUnicastPackets { get; private set; }
        public long OutOtherPackets { get; private set; }
        public long OutDiscards { get; private set; }
        public long OutErrors { get; private set; }
        public long OutUnicastBytes { get; private set; }
        public long OutMulticastBytes { get; private set; }
        public long OutBroadcastBytes { get; private set; }
        public long OutQueueLength { get; private set; }

        internal Interface()
        {
        }

        public Interface(InterfaceIdentifier identifier)
        {
            var row = new MIB_IF_ROW2
            {
                InterfaceIndex = (uint)identifier.Index,
                InterfaceLuid = (ulong)identifier.Luid,
            };

            IpHlpApiDll.GetIfEntry2(ref row).ThrowIfError();

            Fill(this, row);
        }

        internal static Interface Fill(Interface instance, MIB_IF_ROW2 row)
        {
            instance.Luid = (long)row.InterfaceLuid;
            instance.Index = (int)row.InterfaceIndex;
            instance.Guid = row.InterfaceGuid;
            instance.Name = row.Alias;
            instance.Description = row.Description;

            instance.PhysicalAddress = new byte[row.PhysicalAddressLength];
            Array.Copy(row.PhysicalAddress, instance.PhysicalAddress, instance.PhysicalAddress.Length);

            instance.PermanentPhysicalAddress = new byte[row.PhysicalAddressLength];
            Array.Copy(row.PermanentPhysicalAddress, instance.PermanentPhysicalAddress, instance.PermanentPhysicalAddress.Length);

            instance.Mtu = (int)row.Mtu;
            instance.Type = row.Type;
            instance.TunnelType = row.TunnelType;
            instance.MediaType = row.MediaType;
            instance.PhysicalMediumType = row.PhysicalMediumType;
            instance.AccessType = row.AccessType;
            instance.DirectionType = row.DirectionType;
            instance.Flags = row.InterfaceAndOperStatusFlags;
            instance.OperStatus = row.OperStatus;
            instance.AdminStatus = row.AdminStatus;
            instance.MediaConnectState = row.MediaConnectState;
            instance.NetworkGuid = row.NetworkGuid;
            instance.ConnectionType = row.ConnectionType;
            instance.TransmitLinkSpeed = (long)row.TransmitLinkSpeed;
            instance.ReceiveLinkSpeed = (long)row.ReceiveLinkSpeed;
            instance.InBytes = (long)row.InOctets;
            instance.InUnicastPackets = (long)row.InUcastPkts;
            instance.InOtherPackets = (long)row.InNUcastPkts;
            instance.InDiscards = (long)row.InDiscards;
            instance.InErrors = (long)row.InErrors;
            instance.InUnknownPackets = (long)row.InUnknownProtos;
            instance.InUnicastBytes = (long)row.InUcastOctets;
            instance.InMulticastBytes = (long)row.InMulticastOctets;
            instance.InBroadcastBytes = (long)row.InBroadcastOctets;
            instance.OutBytes = (long)row.OutOctets;
            instance.OutUnicastPackets = (long)row.OutUcastPkts;
            instance.OutOtherPackets = (long)row.OutNUcastPkts;
            instance.OutDiscards = (long)row.OutDiscards;
            instance.OutErrors = (long)row.OutErrors;
            instance.OutUnicastBytes = (long)row.OutUcastOctets;
            instance.OutMulticastBytes = (long)row.OutMulticastOctets;
            instance.OutBroadcastBytes = (long)row.OutBroadcastOctets;
            instance.OutQueueLength = (long)row.OutQLen;

            return instance;
        }

        internal static Interface From(MIB_IF_ROW2 row)
            => Fill(new(), row);

        public void AddRoute(IPAddress destination, IPAddress mask, IPAddress nextHop, int metric)
        {
            var row = new MIB_IPFORWARD_ROW2_IN();
            IpHlpApiDll.InitializeIpForwardEntry(ref row);

            row.InterfaceLuid = (ulong)Luid;
            row.InterfaceIndex = (uint)Index;
            row.DestinationPrefix.Prefix = (SOCKADDR_IN)destination;
            row.DestinationPrefix.PrefixLength = mask.GetMaskCidrLength();
            row.NextHop = (SOCKADDR_IN)nextHop;

            // TODO metric? see documentation (row.Metric is an offset to the interface metric obtained via GetIpInterfaceEntry)

            IpHlpApiDll.CreateIpForwardEntry2(ref row).ThrowIfError();
        }

        public void RemoveRoute(IPAddress destination, IPAddress mask, IPAddress nextHop)
        {
            var row = new MIB_IPFORWARD_ROW2_IN();
            IpHlpApiDll.InitializeIpForwardEntry(ref row);

            row.InterfaceLuid = (ulong)Luid;
            row.InterfaceIndex = (uint)Index;
            row.DestinationPrefix.Prefix = (SOCKADDR_IN)destination;
            row.DestinationPrefix.PrefixLength = mask.GetMaskCidrLength();
            row.NextHop = (SOCKADDR_IN)nextHop;

            IpHlpApiDll.DeleteIpForwardEntry2(ref row).ThrowIfError();
        }
    }
}
