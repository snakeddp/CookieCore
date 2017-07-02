namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5738)]
    public class HouseBuyRequestMessage
    {
        [CustomVar]
        public long ProposedPrice { get; set; }
    }
}