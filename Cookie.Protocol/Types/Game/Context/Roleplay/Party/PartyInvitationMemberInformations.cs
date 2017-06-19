
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Choice;
using Cookie.Protocol.Types.Game.Context.Roleplay.Party.Companion;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(376)]
    public class PartyInvitationMemberInformations : CharacterBaseInformations
    {
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }
        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}
