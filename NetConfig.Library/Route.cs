using LaXiS.NetConfig.Library.WinApi;
using System.Net;

namespace LaXiS.NetConfig.Library
{
    public class Route
    {
        public InterfaceIdentifier Interface { get; }
        public IPAddress Destination { get; }
        public IPAddress Mask { get; }
        public int MaskCidrLength { get; }
        public IPAddress NextHop { get; }
        public int SitePrefixLength { get; }
        public int ValidLifetime { get; }
        public int PreferredLifetime { get; }
        public int Metric { get; }
        public RouteProtocol Protocol { get; }
        public bool Loopback { get; }
        public bool AutoconfigureAddress { get; }
        public bool Publish { get; }
        public bool Immortal { get; }
        public int Age { get; }
        public RouteOrigin Origin { get; }

        internal Route(MIB_IPFORWARD_ROW2_IN row)
        {
            Interface = new()
            {
                Luid = (long)row.InterfaceLuid,
                Index = (int)row.InterfaceIndex,
            };
            Destination = (IPAddress)row.DestinationPrefix.Prefix;
            Mask = IpExtensions.GetMaskAddress(row.DestinationPrefix.PrefixLength);
            MaskCidrLength = row.DestinationPrefix.PrefixLength;
            NextHop = (IPAddress)row.NextHop;
            SitePrefixLength = row.SitePrefixLength;
            ValidLifetime = (int)row.ValidLifetime;
            PreferredLifetime = (int)row.PreferredLifetime;
            Metric = (int)row.Metric;
            Protocol = row.Protocol;
            Loopback = row.Loopback;
            AutoconfigureAddress = row.AutoconfigureAddress;
            Publish = row.Publish;
            Immortal = row.Immortal;
            Age = (int)row.Age;
            Origin = row.Origin;
        }
    }
}
