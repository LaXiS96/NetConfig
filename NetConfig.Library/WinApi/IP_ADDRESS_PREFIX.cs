namespace LaXiS.NetConfig.Library.WinApi
{
    internal struct IP_ADDRESS_PREFIX<T> where T : SOCKADDR_INET
    {
        public T Prefix;
        public byte PrefixLength;
    }
}
