
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6330)]
    public class GameActionFightCastOnTargetRequestMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }
        public double TargetId { get; set; }
    }
}
