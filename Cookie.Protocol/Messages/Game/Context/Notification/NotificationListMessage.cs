using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Notification
{
    [NetworkMessage(6087)]
    public class NotificationListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Flags { get; set; }
    }
}