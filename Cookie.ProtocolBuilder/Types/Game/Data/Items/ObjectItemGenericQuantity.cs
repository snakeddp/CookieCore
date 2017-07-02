namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(483)]
    public class ObjectItemGenericQuantity : Item
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}