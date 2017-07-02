namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(470)]
    public class NamedPartyTeamWithOutcome
    {
        public NamedPartyTeam Team { get; set; }

        [CustomVar]
        public ushort Outcome { get; set; }
    }
}