using LaXiS.NetConfig.Library.WinApi;
using System.Net;

namespace LaXiS.NetConfig.Library
{
    public class Route
    {
        public IPAddress Destination { get; }
        public IPAddress Mask { get; }
        // Policy ?
        public IPAddress NextHop { get; }
        public uint InterfaceIndex { get; } // TODO decode interface
        public string Type { get; } // TODO use enum
        public string Protocol { get; } // TODO use enum
        public TimeSpan Age { get; }
        public uint NextHopAS { get; }
        public uint[] Metrics { get; }

        internal Route(MIB_IPFORWARDROW row)
        {
            Destination = new IPAddress(row.dwForwardDest);
            Mask = new IPAddress(row.dwForwardMask);
            NextHop = new IPAddress(row.dwForwardNextHop);
            InterfaceIndex = row.dwForwardIfIndex;
            Type = Enum.GetName(row.dwForwardType);
            Protocol = Enum.GetName(row.dwForwardProto);
            Age = TimeSpan.FromSeconds(row.dwForwardAge);
            NextHopAS = row.dwForwardNextHopAS;
            Metrics = new[] { row.dwForwardMetric1, row.dwForwardMetric2, row.dwForwardMetric3, row.dwForwardMetric4, row.dwForwardMetric5 };
        }

        internal Route(MIB_IPFORWARD_ROW2_IN row)
        {
            Destination = (IPAddress)row.DestinationPrefix.Prefix;
            // TODO
            //Mask = ;
            //NextHop =;
            //InterfaceIndex =;
            //Type =;
            //Protocol =;
            //Age =;
            //NextHopAS =;
            //Metrics =;
        }
    }
}
