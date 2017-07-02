namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(6735)]
    public class AbstractPresetDeleteMessage
    {
        public sbyte PresetId { get; set; }
    }
}