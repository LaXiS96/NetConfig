using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace LaXiS.NetConfig.Library
{
    internal static class IpExtensions
    {
        /// <summary>
        /// Convert to network-byte-order integer
        /// </summary>
        public static uint ToInteger(this IPAddress address) // TODO probably needs different handling for IPv6
            => (uint)IPAddress.HostToNetworkOrder(BitConverter.ToInt32(address.GetAddressBytes()));

        /// <summary>
        /// Get CIDR length if the address represents a valid network mask
        /// </summary>
        public static byte GetMaskCidrLength(this IPAddress mask)
        {
            var address = mask.ToInteger();
            var addressBits = mask.AddressFamily switch
            {
                AddressFamily.InterNetwork => 32,
                AddressFamily.InterNetworkV6 => 128,
                _ => throw new Exception($"Unsupported address family: {mask.AddressFamily}")
            };

            var zeros = BitOperations.TrailingZeroCount(address);
            var expected = (uint)~((1 << zeros) - 1);
            if (address != expected)
                throw new Exception("Mask is not left-contiguous");

            return (byte)(addressBits - zeros);
        }

        /// <summary>
        /// Get network mask address for the given CIDR length
        /// </summary>
        public static IPAddress GetMaskAddress(int cidrLength)
            => cidrLength < 0 || cidrLength > 32
                ? throw new ArgumentOutOfRangeException(nameof(cidrLength))
                : cidrLength == 0
                    ? new IPAddress(0)
                    : new((uint)IPAddress.NetworkToHostOrder(~((1 << (32 - cidrLength)) - 1)));
    }
}
