namespace Cookie.Protocol.Types.Game.Dare
{
    [NetworkType(501)]
    public class DareCriteria
    {
        public sbyte Type { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] Params { get; set; }
    }
}