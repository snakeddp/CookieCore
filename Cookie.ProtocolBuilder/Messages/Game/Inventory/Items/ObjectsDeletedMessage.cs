namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6034)]
    public class ObjectsDeletedMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectUID { get; set; }
    }
}