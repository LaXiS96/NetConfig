using System.Runtime.InteropServices;

namespace LaXiS.NetConfig.Library.WinApi
{
    internal struct MIB_IFTABLE
    {
        public uint dwNumEntries;
        public nint table;
    }

    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/ifmib/ns-ifmib-mib_ifrow">Documentation</a>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct MIB_IFROW
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string wszName;

        public uint dwIndex;
        public IFTYPE dwType;
        public uint dwMtu;
        public uint dwSpeed;
        public uint dwPhysAddrLen;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] bPhysAddr;

        public uint dwAdminStatus;
        public uint dwOperStatus;
        public uint dwLastChange;
        public uint dwInOctets;
        public uint dwInUcastPkts;
        public uint dwInNUcastPkts;
        public uint dwInDiscards;
        public uint dwInErrors;
        public uint dwInUnknownProtos;
        public uint dwOutOctets;
        public uint dwOutUcastPkts;
        public uint dwOutNUcastPkts;
        public uint dwOutDiscards;
        public uint dwOutErrors;
        public uint dwOutQLen;
        public uint dwDescrLen;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] bDescr;
    }
}
