namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(6736)]
    public class AbstractPresetSaveMessage
    {
        public sbyte PresetId { get; set; }
        public sbyte SymbolId { get; set; }
    }
}