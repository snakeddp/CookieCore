using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Notification
{
    [NetworkMessage(6090)]
    public class NotificationUpdateFlagMessage
    {
        [CustomVar]
        public ushort Index { get; set; }
    }
}