namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6556)]
    public class ExchangeMountsStableRemoveMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] MountsId { get; set; }
    }
}