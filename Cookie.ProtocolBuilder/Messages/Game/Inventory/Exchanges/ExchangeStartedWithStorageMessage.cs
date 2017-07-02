namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6236)]
    public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
    {
        [CustomVar]
        public uint StorageMaxSlot { get; set; }
    }
}