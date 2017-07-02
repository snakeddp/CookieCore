namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(5645)]
    public class StorageKamasUpdateMessage
    {
        [CustomVar]
        public long KamasTotal { get; set; }
    }
}