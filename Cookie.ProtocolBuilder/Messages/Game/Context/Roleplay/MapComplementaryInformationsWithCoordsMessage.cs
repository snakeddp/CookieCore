namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6268)]
    public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
    {
        public short WorldX { get; set; }
        public short WorldY { get; set; }
    }
}