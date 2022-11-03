using LaXiS.NetConfig.Library;

namespace LaXiS.NetConfig.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ifaces = IpHelper.GetInterfaces();
            var ifaceIndex = IpHelper.GetInterface(13);
            var ifaceLuid = IpHelper.GetInterface(1689399683186688L);

            var routes = IpHelper.GetRoutes();

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