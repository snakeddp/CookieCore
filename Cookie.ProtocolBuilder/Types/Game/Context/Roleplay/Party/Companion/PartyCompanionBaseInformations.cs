using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party.Companion
{
    [NetworkType(453)]
    public class PartyCompanionBaseInformations
    {
        public sbyte IndexId { get; set; }
        public sbyte CompanionGenericId { get; set; }
        public EntityLook EntityLook { get; set; }
    }
}