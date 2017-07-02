namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(387)]
    public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
    {
        [CustomVar]
        public uint Quantity { get; set; }
    }
}