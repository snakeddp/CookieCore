
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Notification
{
    [NetworkMessage(6103)]
    public class NotificationByServerMessage
    {
        [CustomVar]
        public ushort Id { get; set; }
        [LengthType(typeof(short), true)]
        public string[] Parameters { get; set; }
        [RegularBool]
        public bool ForceOpen { get; set; }
    }
}
