using LaXiS.NetConfig.Library;
using System.Net;
using System.Net.Sockets;

namespace LaXiS.NetConfig.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ifaces = IpHelper.GetInterfaces();
            var ifaceIndex = new Interface(14);
            var ifaceLuid = new Interface(1689399683186688L);

            try
            {
                ifaceLuid.AddRoute(IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var routes = IpHelper.GetRoutes(AddressFamily.InterNetwork);

            try
            {
                ifaceLuid.RemoveRoute(IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}