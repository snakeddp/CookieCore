using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Objects
{
    [NetworkMessage(5944)]
    public class ObjectGroundRemovedMultipleMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Cells { get; set; }
    }
}