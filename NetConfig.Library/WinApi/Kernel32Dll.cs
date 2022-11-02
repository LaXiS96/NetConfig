using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    internal static class Kernel32Dll
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern uint FormatMessage(FormatMessageFlags dwFlags, nint lpSource, uint dwMessageId, uint dwLanguageId, out string lpBuffer, uint nSize, nint Arguments);
    }

    [Flags]
    public enum FormatMessageFlags : uint
    {
        MAX_WIDTH_MASK = 0xFF,
        ALLOCATE_BUFFER = 0x100,
        IGNORE_INSERTS = 0x200,
        FROM_STRING = 0x400,
        FROM_HMODULE = 0x800,
        FROM_SYSTEM = 0x1000,
        ARGUMENT_ARRAY = 0x2000,
    }
}
