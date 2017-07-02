namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(455)]
    public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
    {
        [CustomVar]
        public ushort CreatureGenericId { get; set; }
    }
}