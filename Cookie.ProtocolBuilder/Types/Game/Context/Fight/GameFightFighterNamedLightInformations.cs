namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(456)]
    public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
    {
        public string Name { get; set; }
    }
}