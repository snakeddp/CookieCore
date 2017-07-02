namespace Cookie.Protocol.Messages.Game.Context.Notification
{
    [NetworkMessage(6090)]
    public class NotificationUpdateFlagMessage
    {
        [CustomVar]
        public ushort Index { get; set; }
    }
}