namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(49)]
    public class SpellItem : Item
    {
        public int SpellId { get; set; }
        public short SpellLevel { get; set; }
    }
}