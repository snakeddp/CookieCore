namespace Cookie.Protocol.Messages.Game.Inventory.Preset
{
    [NetworkMessage(6615)]
    public class IdolsPresetUseMessage
    {
        public sbyte PresetId { get; set; }

        [RegularBool]
        public bool Party { get; set; }
    }
}