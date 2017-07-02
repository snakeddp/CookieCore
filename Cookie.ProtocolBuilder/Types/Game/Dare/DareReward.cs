namespace Cookie.Protocol.Types.Game.Dare
{
    [NetworkType(505)]
    public class DareReward
    {
        public sbyte Type { get; set; }

        [CustomVar]
        public ushort MonsterId { get; set; }

        [CustomVar]
        public long Kamas { get; set; }

        public double DareId { get; set; }
    }
}