namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(360)]
    public class GameFightMinimalStatsPreparation : GameFightMinimalStats
    {
        [CustomVar]
        public uint Initiative { get; set; }
    }
}