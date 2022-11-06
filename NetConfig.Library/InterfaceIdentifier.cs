namespace LaXiS.NetConfig.Library
{
    public class InterfaceIdentifier
    {
        public int Index { get; init; }
        public long Luid { get; init; }

        public static implicit operator InterfaceIdentifier(int index) => new() { Index = index };
        public static implicit operator InterfaceIdentifier(long luid) => new() { Luid = luid };
    }
}
