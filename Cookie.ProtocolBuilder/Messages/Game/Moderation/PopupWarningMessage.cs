namespace Cookie.Protocol.Messages.Game.Moderation
{
    [NetworkMessage(6134)]
    public class PopupWarningMessage
    {
        public sbyte LockDuration { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}