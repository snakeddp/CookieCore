namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(134)]
    public class ObjectItemNotInContainer : Item
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }

        [CustomVar]
        public uint ObjectUID { get; set; }

        [CustomVar]
        public uint Quantity { get; set; }
    }
}