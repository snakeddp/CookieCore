using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(29)]
    public class GameFightMonsterInformations : GameFightAIInformations
    {
        [CustomVar]
        public ushort CreatureGenericId { get; set; }

        public sbyte CreatureGrade { get; set; }
    }
}