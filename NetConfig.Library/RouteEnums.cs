namespace LaXiS.NetConfig.Library
{

    /// <summary>
    /// NL_ROUTE_PROTOCOL
    /// </summary>
    public enum RouteProtocol
    {
        Other = 1,
        Local = 2,
        NetMgmt = 3,
        Icmp = 4,
        Egp = 5,
        Ggp = 6,
        Hello = 7,
        Rip = 8,
        IsIs = 9,
        EsIs = 10,
        Cisco = 11,
        Bbn = 12,
        Ospf = 13,
        Bgp = 14,
        Idpr = 15,
        Eigrp = 16,
        Dvmrp = 17,
        Rpl = 18,
        Dhcp = 19,
        NtAutoStatic = 10002,
        NtStatic = 10006,
        NtStaticNonDod = 10007,
    }

    /// <summary>
    /// NL_ROUTE_ORIGIN
    /// </summary>
    public enum RouteOrigin
    {
        Manual,
        WellKnown,
        Dhcp,
        RouterAdvertisement,
        _6to4,
    }

}
