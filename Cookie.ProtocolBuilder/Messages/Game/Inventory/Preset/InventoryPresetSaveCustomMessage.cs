namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6329)]
    public class InventoryPresetSaveCustomMessage : AbstractPresetSaveMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] ItemsPositions { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ItemsUids { get; set; }
    }
}