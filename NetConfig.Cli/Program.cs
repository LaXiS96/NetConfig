using LaXiS.NetConfig.Library;
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

            var routes = IpHelper.GetRoutes(AddressFamily.InterNetwork);

            //try
            //{
            //    IpHelper.AddRoute(16, IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"), 270);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    IpHelper.RemoveRoute(16, IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}