namespace LaXiS.NetConfig.Library
{
    public class InterfaceIdentifier
    {
        public int Index { get; set; }
        public long Luid { get; set; }

        public static implicit operator InterfaceIdentifier(int index) => new() { Index = index };
        public static implicit operator InterfaceIdentifier(long luid) => new() { Luid = luid };
    }
}
