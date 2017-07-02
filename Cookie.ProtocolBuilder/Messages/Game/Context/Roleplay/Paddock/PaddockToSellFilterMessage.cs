namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6161)]
    public class PaddockToSellFilterMessage
    {
        public int AreaId { get; set; }
        public byte AtLeastNbMount { get; set; }
        public byte AtLeastNbMachine { get; set; }

        [CustomVar]
        public long MaxPrice { get; set; }
    }
}