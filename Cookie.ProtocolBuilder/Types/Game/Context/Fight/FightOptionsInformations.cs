namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(20)]
    public class FightOptionsInformations
    {
        public bool IsSecret { get; set; }
        public bool IsRestrictedToPartyOnly { get; set; }
        public bool IsClosed { get; set; }
        public bool IsAskingForHelp { get; set; }
    }
}