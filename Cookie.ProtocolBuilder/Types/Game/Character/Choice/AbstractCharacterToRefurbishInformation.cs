namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(475)]
    public class AbstractCharacterToRefurbishInformation : AbstractCharacterInformation
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Colors { get; set; }

        [CustomVar]
        public uint CosmeticId { get; set; }
    }
}