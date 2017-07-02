using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(445)]
    public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
    {
        public BasicGuildInformations Guild { get; set; }
    }
}