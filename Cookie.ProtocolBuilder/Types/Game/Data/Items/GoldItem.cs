namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(123)]
    public class GoldItem : Item
    {
        [CustomVar]
        public long Sum { get; set; }
    }
}