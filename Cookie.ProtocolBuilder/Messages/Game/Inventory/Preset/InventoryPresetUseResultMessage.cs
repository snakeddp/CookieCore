namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6163)]
    public class InventoryPresetUseResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }

        [LengthType(typeof(short), true)]
        public sbyte[] UnlinkedPosition { get; set; }
    }
}