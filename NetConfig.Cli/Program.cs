using LaXiS.NetConfig.Library;
using System.Net;

namespace LaXiS.NetConfig.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IpHelper.GetInterfaceInfo(16);

            // TODO check if code even works

            var ifaces = IpHelper.GetInterfaces();
            var routes = IpHelper.GetRoutes();
            //var iface = IpHelper.GetInterface(16);

            try
            {
                IpHelper.AddRoute(16, IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"), 270);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                IpHelper.RemoveRoute(16, IPAddress.Parse("192.168.100.0"), IPAddress.Parse("255.255.255.0"), IPAddress.Parse("192.168.100.254"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}