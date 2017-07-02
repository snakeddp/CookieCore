namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(352)]
    public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
    {
        [CustomVar]
        public long ObjectPrice { get; set; }

        public string BuyCriterion { get; set; }
    }
}