namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6298)]
    public class NumericWhoIsRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}