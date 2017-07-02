namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6289)]
    public class TeleportBuddiesMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}