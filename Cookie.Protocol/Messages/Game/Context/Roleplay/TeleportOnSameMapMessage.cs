using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6048)]
    public class TeleportOnSameMapMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public ushort CellId { get; set; }
    }
}