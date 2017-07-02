namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6562)]
    public class ExchangeHandleMountsStableMessage
    {
        public byte ActionType { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] RidesId { get; set; }
    }
}