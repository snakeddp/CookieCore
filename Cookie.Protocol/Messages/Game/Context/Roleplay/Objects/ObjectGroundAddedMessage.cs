
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Objects
{
    [NetworkMessage(3017)]
    public class ObjectGroundAddedMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}
