namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(378)]
    public class PartyMemberGeoPosition
    {
        public uint MemberId { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}