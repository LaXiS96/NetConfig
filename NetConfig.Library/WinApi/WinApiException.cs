namespace LaXiS.NetConfig.Library.WinApi
{
    internal class WinApiException : Exception
    {
        public WinApiException(uint error) : base(WinError.GetMessage(error))
        {
        }

        public WinApiException(int error) : this((uint)error)
        {
        }
    }
}
