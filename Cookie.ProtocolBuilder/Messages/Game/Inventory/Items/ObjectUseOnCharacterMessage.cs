namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3003)]
    public class ObjectUseOnCharacterMessage : ObjectUseMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }
    }
}