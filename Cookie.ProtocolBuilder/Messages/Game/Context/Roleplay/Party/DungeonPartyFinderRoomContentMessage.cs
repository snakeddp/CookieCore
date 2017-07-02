namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6247)]
    public class DungeonPartyFinderRoomContentMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}