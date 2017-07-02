namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(121)]
    public class SellerBuyerDescriptor
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Quantities { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Types { get; set; }

        public float TaxPercentage { get; set; }
        public float TaxModificationPercentage { get; set; }
        public sbyte MaxItemLevel { get; set; }

        [CustomVar]
        public uint MaxItemPerAccount { get; set; }

        public int NpcContextualId { get; set; }

        [CustomVar]
        public ushort UnsoldDelay { get; set; }
    }
}