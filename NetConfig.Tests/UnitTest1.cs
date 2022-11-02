using LaXiS.NetConfig.Library;

namespace LaXiS.NetConfig.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("0.0.0.0", IpExtensions.GetMaskAddress(0).ToString());
            Assert.Equal("254.0.0.0", IpExtensions.GetMaskAddress(7).ToString());
            Assert.Equal("255.255.128.0", IpExtensions.GetMaskAddress(17).ToString());
            Assert.Equal("255.255.255.255", IpExtensions.GetMaskAddress(32).ToString());
        }
    }
}