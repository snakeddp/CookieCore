namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(5648)]
    public class StorageObjectRemoveMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}