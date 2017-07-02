using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6342)]
    public class PartyMemberInFightMessage : AbstractPartyMessage
    {
        public sbyte Reason { get; set; }

        [CustomVar]
        public long MemberId { get; set; }

        public uint MemberAccountId { get; set; }
        public string MemberName { get; set; }
        public int FightId { get; set; }
        public MapCoordinatesExtended FightMap { get; set; }

        [CustomVar]
        public short TimeBeforeFightStart { get; set; }
    }
}