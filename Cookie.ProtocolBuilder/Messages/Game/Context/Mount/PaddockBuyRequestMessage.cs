namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5951)]
    public class PaddockBuyRequestMessage
    {
        [CustomVar]
        public long ProposedPrice { get; set; }
    }
}