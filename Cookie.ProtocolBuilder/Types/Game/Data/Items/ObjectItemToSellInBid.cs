namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(164)]
    public class ObjectItemToSellInBid : ObjectItemToSell
    {
        public uint UnsoldDelay { get; set; }
    }
}