namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6532)]
    public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectUID { get; set; }
    }
}