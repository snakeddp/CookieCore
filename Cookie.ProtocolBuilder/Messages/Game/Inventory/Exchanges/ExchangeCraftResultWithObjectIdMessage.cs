namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6000)]
    public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
    {
        [CustomVar]
        public ushort ObjectGenericId { get; set; }
    }
}