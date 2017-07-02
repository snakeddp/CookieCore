namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(217)]
    public class FightEntityDispositionInformations : EntityDispositionInformations
    {
        public double CarryingCharacterId { get; set; }
    }
}