namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(3010)]
    public class ObjectMovementMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }

        public sbyte Position { get; set; }
    }
}