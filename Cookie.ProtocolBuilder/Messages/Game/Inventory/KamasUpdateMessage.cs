namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(5537)]
    public class KamasUpdateMessage
    {
        [CustomVar]
        public long KamasTotal { get; set; }
    }
}