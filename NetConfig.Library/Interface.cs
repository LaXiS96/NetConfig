using LaXiS.NetConfig.Library.WinApi;
using System.Text;

namespace LaXiS.NetConfig.Library
{
    public class Interface
    {
        public uint Index { get; }
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }
        public uint Mtu { get; }
        public ulong ReceiveLinkSpeed { get; }
        public ulong TransmitLinkSpeed { get; }
        public byte[] PhysicalAddress { get; }
        // TODO AdminStatus ?
        // TODO OperStatus ?
        public uint LastChange { get; }
        public ulong InBytes { get; }
        public ulong InUnicastBytes { get; }
        public ulong InMulticastBytes { get; }
        public ulong InBroadcastBytes { get; }
        public ulong InUnicastPackets { get; }
        public ulong InOtherPackets { get; }
        public ulong InDiscards { get; }
        public ulong InErrors { get; }
        public ulong InUnknownPackets { get; }
        public ulong OutBytes { get; }
        public ulong OutUnicastBytes { get; }
        public ulong OutMulticastBytes { get; }
        public ulong OutBroadcastBytes { get; }
        public ulong OutUnicastPackets { get; }
        public ulong OutOtherPackets { get; }
        public ulong OutDiscards { get; }
        public ulong OutErrors { get; }
        // TODO OutQLen ?

        internal Interface(MIB_IFROW row)
        {
            Index = row.dwIndex;
            Name = row.wszName;
            Description = Encoding.ASCII.GetString(row.bDescr);
            Type = Enum.GetName(row.dwType);
            Mtu = row.dwMtu;
            ReceiveLinkSpeed = row.dwSpeed;
            TransmitLinkSpeed = row.dwSpeed;

            PhysicalAddress = new byte[row.dwPhysAddrLen];
            Array.Copy(row.bPhysAddr, PhysicalAddress, PhysicalAddress.Length);

            LastChange = row.dwLastChange;
            InBytes = row.dwInOctets;
            InUnicastPackets = row.dwInUcastPkts;
            InOtherPackets = row.dwInNUcastPkts;
            InDiscards = row.dwInDiscards;
            InErrors = row.dwInErrors;
            InUnknownPackets = row.dwInUnknownProtos;
            OutBytes = row.dwOutOctets;
            OutUnicastPackets = row.dwOutUcastPkts;
            OutOtherPackets = row.dwOutNUcastPkts;
            OutDiscards = row.dwOutDiscards;
            OutErrors = row.dwOutErrors;
        }

        internal Interface(MIB_IF_ROW2 row)
        {
            Index = row.InterfaceIndex;
            Name = row.Alias;
            Description = row.Description;
            Type = Enum.GetName(row.Type);
            Mtu = row.Mtu;
            ReceiveLinkSpeed = row.ReceiveLinkSpeed;
            TransmitLinkSpeed = row.TransmitLinkSpeed;

            PhysicalAddress = new byte[row.PhysicalAddressLength];
            Array.Copy(row.PhysicalAddress, PhysicalAddress, PhysicalAddress.Length);

            LastChange = 0;
            InBytes = row.InOctets;
            InUnicastBytes = row.InUcastOctets;
            InMulticastBytes = row.InMulticastOctets;
            InBroadcastBytes = row.InBroadcastOctets;
            InUnicastPackets = row.InUcastPkts;
            InOtherPackets = row.InNUcastPkts;
            InDiscards = row.InDiscards;
            InErrors = row.InErrors;
            InUnknownPackets = row.InUnknownProtos;
            OutBytes = row.OutOctets;
            OutUnicastBytes = row.OutUcastOctets;
            OutMulticastBytes = row.OutMulticastOctets;
            OutBroadcastBytes = row.OutBroadcastOctets;
            OutUnicastPackets = row.OutUcastPkts;
            OutOtherPackets = row.OutNUcastPkts;
            OutDiscards = row.OutDiscards;
            OutErrors = row.OutErrors;
        }
    }
}
