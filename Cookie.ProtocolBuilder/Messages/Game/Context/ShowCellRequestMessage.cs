namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(5611)]
    public class ShowCellRequestMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}