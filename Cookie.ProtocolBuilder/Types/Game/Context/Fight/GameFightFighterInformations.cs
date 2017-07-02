namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(143)]
    public class GameFightFighterInformations : GameContextActorInformations
    {
        public sbyte TeamId { get; set; }
        public sbyte Wave { get; set; }

        [RegularBool]
        public bool Alive { get; set; }

        public GameFightMinimalStats Stats { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PreviousPositions { get; set; }
    }
}