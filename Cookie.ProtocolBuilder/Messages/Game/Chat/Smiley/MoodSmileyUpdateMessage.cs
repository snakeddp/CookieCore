namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6388)]
    public class MoodSmileyUpdateMessage
    {
        public uint AccountId { get; set; }

        [CustomVar]
        public long PlayerId { get; set; }

        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}