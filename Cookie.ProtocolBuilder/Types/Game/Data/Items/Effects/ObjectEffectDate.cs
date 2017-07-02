namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(72)]
    public class ObjectEffectDate : ObjectEffect
    {
        [CustomVar]
        public ushort Year { get; set; }

        public sbyte Month { get; set; }
        public sbyte Day { get; set; }
        public sbyte Hour { get; set; }
        public sbyte Minute { get; set; }
    }
}