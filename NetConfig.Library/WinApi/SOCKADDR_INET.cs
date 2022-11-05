using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    /// <summary>
    /// SOCKADDR_INET is an union between SOCKADDR_IN, SOCKADDR_IN6, ADDRESS_FAMILY
    /// </summary>
    internal interface SOCKADDR_INET
    {
    }

    /// <summary>
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/ws2def/ns-ws2def-sockaddr_in">Documentation</a>
    /// </summary>
    internal struct SOCKADDR_IN : SOCKADDR_INET
    {
        public ushort sin_family = (ushort)AddressFamily.InterNetwork;
        public ushort sin_port = 0;
        public uint sin_addr = 0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] sin_zero = new byte[8];

        /// <summary>Padding to reach same size as <see cref="SOCKADDR_IN6"/></summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] public byte[] _ = new byte[12];

        public SOCKADDR_IN()
        {
        }

        private SOCKADDR_IN(IPAddress ip) : this()
        {
            if (ip.AddressFamily != AddressFamily.InterNetwork)
                throw new InvalidOperationException("Address family must be IPv4");

            sin_addr = ip.ToInteger();
        }

        public static explicit operator SOCKADDR_IN(IPAddress ip) => new(ip);
        public static explicit operator IPAddress(SOCKADDR_IN addr) => new(addr.sin_addr);
    }

    internal struct SOCKADDR_IN6 : SOCKADDR_INET
    {
        public ushort sin6_family = (ushort)AddressFamily.InterNetworkV6;
        public ushort sin6_port = 0;
        public uint sin6_flowinfo = 0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public byte[] sin6_addr = new byte[16];
        public uint sin6_scope_id = 0;

        public SOCKADDR_IN6()
        {
        }

        private SOCKADDR_IN6(IPAddress ip) : this()
        {
            if (ip.AddressFamily != AddressFamily.InterNetworkV6)
                throw new InvalidOperationException("Address family must be IPv6");

            sin6_addr = ip.GetAddressBytes();
        }

        public static explicit operator SOCKADDR_IN6(IPAddress ip) => new(ip);
        public static explicit operator IPAddress(SOCKADDR_IN6 addr) => new(addr.sin6_addr);
    }
}