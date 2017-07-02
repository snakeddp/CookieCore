using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(444)]
    public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
    {
        public BasicAllianceInformations Alliance { get; set; }
    }
}