using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Modificator
{
    [NetworkMessage(6493)]
    public class AreaFightModificatorUpdateMessage
    {
        public int SpellPairId { get; set; }
    }
}