using LaXiS.NetConfig.Library.WinApi;
using System.Net.Sockets;

namespace LaXiS.NetConfig.Library
{
    public class IpInterface
    {
        public InterfaceIdentifier Identifier { get; private set; }
        public AddressFamily Family { get; private set; }
        public int MaxReassemblySize { get; private set; }
        public long InterfaceIdentifier { get; private set; }
        public int MinRouterAdvertisementInterval { get; private set; }
        public int MaxRouterAdvertisementInterval { get; private set; }
        public bool AdvertisingEnabled { get; private set; }
        public bool ForwardingEnabled { get; private set; }
        public bool WeakHostSend { get; private set; }
        public bool WeakHostReceive { get; private set; }
        public bool UseAutomaticMetric { get; private set; }
        public bool UseNeighborUnreachabilityDetection { get; private set; }
        public bool ManagedAddressConfigurationSupported { get; private set; }
        public bool OtherStatefulConfigurationSupported { get; private set; }
        public bool AdvertiseDefaultRoute { get; private set; }
        public RouterDiscoveryBehavior RouterDiscoveryBehavior { get; private set; }
        public int DadTransmits { get; private set; }
        public int BaseReachableTime { get; private set; }
        public int RetransmitTime { get; private set; }
        public int PathMtuDiscoveryTimeout { get; private set; }
        public LinkLocalAddressBehavior LinkLocalAddressBehavior { get; private set; }
        public int LinkLocalAddressTimeout { get; private set; }
        public int[] ZoneIndices { get; private set; }
        public int SitePrefixLength { get; private set; }
        public int Metric { get; private set; }
        public int NlMtu { get; private set; }
        public bool Connected { get; private set; }
        public bool SupportsWakeUpPatterns { get; private set; }
        public bool SupportsNeighborDiscovery { get; private set; }
        public bool SupportsRouterDiscovery { get; private set; }
        public int ReachableTime { get; private set; }
        public InterfaceOffloadFlags TransmitOffload { get; private set; }
        public InterfaceOffloadFlags ReceiveOffload { get; private set; }
        public bool DisableDefaultRoutes { get; private set; }

        public IpInterface(InterfaceIdentifier identifier, AddressFamily family)
        {
            var row = new MIB_IPINTERFACE_ROW
            {
                InterfaceIndex = (uint)identifier.Index,
                InterfaceLuid = (ulong)identifier.Luid,
                Family = (ushort)family,
            };
            IpHlpApiDll.GetIpInterfaceEntry(ref row).ThrowIfError();
            Fill(this, row);
        }

        internal static IpInterface Fill(IpInterface instance, MIB_IPINTERFACE_ROW row)
        {
            instance.Identifier = new()
            {
                Index = (int)row.InterfaceIndex,
                Luid = (long)row.InterfaceLuid,
            };
            instance.Family = (AddressFamily)row.Family;
            instance.MaxReassemblySize = (int)row.MaxReassemblySize;
            instance.InterfaceIdentifier = (long)row.InterfaceIdentifier;
            instance.MinRouterAdvertisementInterval = (int)row.MinRouterAdvertisementInterval;
            instance.MaxRouterAdvertisementInterval = (int)row.MaxRouterAdvertisementInterval;
            instance.AdvertisingEnabled = row.AdvertisingEnabled;
            instance.ForwardingEnabled = row.ForwardingEnabled;
            instance.WeakHostSend = row.WeakHostSend;
            instance.WeakHostReceive = row.WeakHostReceive;
            instance.UseAutomaticMetric = row.UseAutomaticMetric;
            instance.UseNeighborUnreachabilityDetection = row.UseNeighborUnreachabilityDetection;
            instance.ManagedAddressConfigurationSupported = row.ManagedAddressConfigurationSupported;
            instance.OtherStatefulConfigurationSupported = row.OtherStatefulConfigurationSupported;
            instance.AdvertiseDefaultRoute = row.AdvertiseDefaultRoute;
            instance.RouterDiscoveryBehavior = row.RouterDiscoveryBehavior;
            instance.DadTransmits = (int)row.DadTransmits;
            instance.BaseReachableTime = (int)row.BaseReachableTime;
            instance.RetransmitTime = (int)row.RetransmitTime;
            instance.PathMtuDiscoveryTimeout = (int)row.PathMtuDiscoveryTimeout;
            instance.LinkLocalAddressBehavior = row.LinkLocalAddressBehavior;
            instance.LinkLocalAddressTimeout = (int)row.LinkLocalAddressTimeout;
            instance.ZoneIndices = Array.ConvertAll(row.ZoneIndices, x => (int)x);
            instance.SitePrefixLength = (int)row.SitePrefixLength;
            instance.Metric = (int)row.Metric;
            instance.NlMtu = (int)row.NlMtu;
            instance.Connected = row.Connected;
            instance.SupportsWakeUpPatterns = row.SupportsWakeUpPatterns;
            instance.SupportsNeighborDiscovery = row.SupportsNeighborDiscovery;
            instance.SupportsRouterDiscovery = row.SupportsRouterDiscovery;
            instance.ReachableTime = (int)row.ReachableTime;
            instance.TransmitOffload = row.TransmitOffload;
            instance.ReceiveOffload = row.ReceiveOffload;
            instance.DisableDefaultRoutes = row.DisableDefaultRoutes;

            return instance;
        }
    }
}
