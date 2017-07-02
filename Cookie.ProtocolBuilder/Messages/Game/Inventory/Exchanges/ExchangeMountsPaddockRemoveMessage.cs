namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6559)]
    public class ExchangeMountsPaddockRemoveMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] MountsId { get; set; }
    }
}