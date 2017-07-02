namespace Cookie.Protocol.Messages.Game.Inventory.Storage
{
    [NetworkMessage(6035)]
    public class StorageObjectsRemoveMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectUIDList { get; set; }
    }
}