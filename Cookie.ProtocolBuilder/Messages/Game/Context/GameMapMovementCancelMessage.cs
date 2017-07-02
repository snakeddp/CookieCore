namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(953)]
    public class GameMapMovementCancelMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}