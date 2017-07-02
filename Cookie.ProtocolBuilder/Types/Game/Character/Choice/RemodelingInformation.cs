namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(480)]
    public class RemodelingInformation
    {
        public string Name { get; set; }
        public byte Breed { get; set; }

        [RegularBool]
        public bool Sex { get; set; }

        [CustomVar]
        public ushort CosmeticId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Colors { get; set; }
    }
}