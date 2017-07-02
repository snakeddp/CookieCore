namespace Cookie.Protocol.Types.Game.Inventory.Preset
{
    [NetworkType(355)]
    public class Preset
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }

        [RegularBool]
        public bool Mount { get; set; }
    }
}