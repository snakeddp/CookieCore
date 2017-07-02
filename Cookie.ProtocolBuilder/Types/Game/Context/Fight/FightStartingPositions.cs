namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(513)]
    public class FightStartingPositions
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PositionsForChallengers { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PositionsForDefenders { get; set; }
    }
}