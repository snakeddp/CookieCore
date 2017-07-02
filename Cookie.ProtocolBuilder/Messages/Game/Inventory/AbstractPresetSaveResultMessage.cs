namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(6734)]
    public class AbstractPresetSaveResultMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte Code { get; set; }
    }
}