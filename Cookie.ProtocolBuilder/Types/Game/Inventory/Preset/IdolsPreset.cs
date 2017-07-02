namespace Cookie.Protocol.Types.Game.Inventory.Preset
{
    [NetworkType(491)]
    public class IdolsPreset
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] IdolId { get; set; }
    }
}