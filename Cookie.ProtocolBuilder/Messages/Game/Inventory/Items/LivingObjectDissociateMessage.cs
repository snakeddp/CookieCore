namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5723)]
    public class LivingObjectDissociateMessage
    {
        [CustomVar]
        public uint LivingUID { get; set; }

        public sbyte LivingPosition { get; set; }
    }
}