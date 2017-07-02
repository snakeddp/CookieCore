namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(48)]
    public class GameFightTaxCollectorInformations : GameFightAIInformations
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public sbyte Level { get; set; }
    }
}