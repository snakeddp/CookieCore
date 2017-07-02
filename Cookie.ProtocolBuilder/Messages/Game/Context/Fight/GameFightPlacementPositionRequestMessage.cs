namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(704)]
    public class GameFightPlacementPositionRequestMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}