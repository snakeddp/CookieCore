namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(954)]
    public class GameMapNoMovementMessage
    {
        public short CellX { get; set; }
        public short CellY { get; set; }
    }
}