using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    internal static class WinError
    {
        public const uint NO_ERROR = 0;
        public const uint ACCESS_DENIED = 5;
        public const uint INVALID_DATA = 13;
        public const uint NOT_SUPPORTED = 50;
        public const uint INVALID_PARAMETER = 87;
        public const uint INSUFFICIENT_BUFFER = 122;
        public const uint NO_DATA = 232;
        public const uint CAN_NOT_COMPLETE = 1003;
        public const uint NOT_FOUND = 1168;

        public static string GetMessage(uint error)
        {
            var chars = Kernel32Dll.FormatMessage(
                FormatMessageFlags.ALLOCATE_BUFFER | FormatMessageFlags.FROM_SYSTEM | FormatMessageFlags.IGNORE_INSERTS,
                0,
                error,
                0,
                out string message,
                0,
                0);

            if (chars == 0)
                throw new WinApiException(Marshal.GetLastWin32Error());

            return message.Trim();
        }
    }
}
