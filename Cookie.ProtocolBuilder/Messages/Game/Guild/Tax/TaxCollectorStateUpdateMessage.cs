namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(6455)]
    public class TaxCollectorStateUpdateMessage
    {
        public int UniqueId { get; set; }
        public byte State { get; set; }
    }
}