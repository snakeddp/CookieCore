namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6457)]
    public class MimicryObjectEraseRequestMessage
    {
        [CustomVar]
        public uint HostUID { get; set; }

        public sbyte HostPos { get; set; }
    }
}