namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(130)]
    public class PaddockBuyableInformations
    {
        [CustomVar]
        public long Price { get; set; }

        [RegularBool]
        public bool Locked { get; set; }
    }
}