
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(6110)]
    public class EntityTalkMessage
    {
        public double EntityId { get; set; }
        [CustomVar]
        public ushort TextId { get; set; }
        [LengthType(typeof(short), true)]
        public string[] Parameters { get; set; }
    }
}
