using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions
{
    [NetworkMessage(957)]
    public class GameActionAcknowledgementMessage
    {
        [RegularBool]
        public bool Valid { get; set; }

        public byte ActionId { get; set; }
    }
}