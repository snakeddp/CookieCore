namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3019)]
    public class ObjectUseMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
    }
}