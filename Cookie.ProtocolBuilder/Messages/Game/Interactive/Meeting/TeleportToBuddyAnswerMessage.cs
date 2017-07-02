namespace Cookie.Protocol.Messages.Game.Interactive.Meeting
{
    [NetworkMessage(6293)]
    public class TeleportToBuddyAnswerMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }

        [CustomVar]
        public long BuddyId { get; set; }

        [RegularBool]
        public bool Accept { get; set; }
    }
}