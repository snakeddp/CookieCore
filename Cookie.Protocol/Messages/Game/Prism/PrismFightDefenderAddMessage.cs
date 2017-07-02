using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5895)]
    public class PrismFightDefenderAddMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        [CustomVar]
        public ushort FightId { get; set; }

        public CharacterMinimalPlusLookInformations Defender { get; set; }
    }
}