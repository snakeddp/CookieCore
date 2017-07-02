using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guest
{
    [NetworkMessage(6505)]
    public class GuestModeMessage
    {
        [RegularBool]
        public bool Active { get; set; }
    }
}