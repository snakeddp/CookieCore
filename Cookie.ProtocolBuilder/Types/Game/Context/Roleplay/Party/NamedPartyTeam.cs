namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(469)]
    public class NamedPartyTeam
    {
        public sbyte TeamId { get; set; }
        public string PartyName { get; set; }
    }
}