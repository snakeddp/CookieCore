using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5893)]
    public class PrismFightAttackerAddMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        [CustomVar]
        public ushort FightId { get; set; }

        public CharacterMinimalPlusLookInformations Attacker { get; set; }
    }
}