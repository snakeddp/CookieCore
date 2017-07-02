namespace Cookie.Protocol.Types.Game.Inventory.Preset
{
    [NetworkType(354)]
    public class PresetItem
    {
        public sbyte Position { get; set; }

        [CustomVar]
        public ushort ObjGid { get; set; }

        [CustomVar]
        public uint ObjUid { get; set; }
    }
}