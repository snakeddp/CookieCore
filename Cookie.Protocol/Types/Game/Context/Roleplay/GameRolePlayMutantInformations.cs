using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(3)]
    public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
    {
        [CustomVar]
        public ushort MonsterId { get; set; }

        public byte PowerLevel { get; set; }
    }
}