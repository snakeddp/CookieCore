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