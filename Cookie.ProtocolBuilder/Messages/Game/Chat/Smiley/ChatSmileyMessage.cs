namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(801)]
    public class ChatSmileyMessage
    {
        public double EntityId { get; set; }

        [CustomVar]
        public ushort SmileyId { get; set; }

        public uint AccountId { get; set; }
    }
}