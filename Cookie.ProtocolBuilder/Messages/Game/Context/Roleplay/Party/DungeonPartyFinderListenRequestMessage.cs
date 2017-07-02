namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6246)]
    public class DungeonPartyFinderListenRequestMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}