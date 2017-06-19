
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(1005)]
    public class GameActionFightCastRequestMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }
        public short CellId { get; set; }
    }
}
