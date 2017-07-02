namespace Cookie.Protocol.Messages.Game.Actions
{
    [NetworkMessage(1000)]
    public class AbstractGameActionMessage
    {
        [CustomVar]
        public ushort ActionId { get; set; }

        public double SourceId { get; set; }
    }
}