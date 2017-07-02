namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(481)]
    public class DecraftedItemStackInfo
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        public float BonusMin { get; set; }
        public float BonusMax { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] RunesId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] RunesQty { get; set; }
    }
}