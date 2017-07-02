using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Types.Game.Dare
{
    [NetworkType(502)]
    public class DareInformations
    {
        public double DareId { get; set; }
        public CharacterBasicMinimalInformations Creator { get; set; }

        [CustomVar]
        public long SubscriptionFee { get; set; }

        [CustomVar]
        public long Jackpot { get; set; }

        public ushort MaxCountWinners { get; set; }
        public double EndDate { get; set; }

        [RegularBool]
        public bool IsPrivate { get; set; }

        [CustomVar]
        public uint GuildId { get; set; }

        [CustomVar]
        public uint AllianceId { get; set; }

        public double StartDate { get; set; }
    }
}