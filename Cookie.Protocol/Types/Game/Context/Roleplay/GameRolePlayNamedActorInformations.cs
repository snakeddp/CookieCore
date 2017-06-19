
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(154)]
    public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
    {
        public string Name { get; set; }
    }
}
