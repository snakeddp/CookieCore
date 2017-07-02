namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6527)]
    public class SymbioticObjectAssociatedMessage
    {
        [CustomVar]
        public uint HostUID { get; set; }
    }
}