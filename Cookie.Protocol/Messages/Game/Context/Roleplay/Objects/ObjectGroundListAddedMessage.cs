using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Objects
{
    [NetworkMessage(5925)]
    public class ObjectGroundListAddedMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Cells { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] ReferenceIds { get; set; }
    }
}