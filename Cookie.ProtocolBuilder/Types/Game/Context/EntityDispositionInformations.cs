namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(60)]
    public class EntityDispositionInformations
    {
        public short CellId { get; set; }
        public sbyte Direction { get; set; }
    }
}