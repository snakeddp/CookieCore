namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(107)]
    public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
    {
        public double Id { get; set; }
    }
}