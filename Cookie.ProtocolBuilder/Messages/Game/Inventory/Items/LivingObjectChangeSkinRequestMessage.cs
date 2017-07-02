namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(5725)]
    public class LivingObjectChangeSkinRequestMessage
    {
        [CustomVar]
        public uint LivingUID { get; set; }

        public sbyte LivingPosition { get; set; }

        [CustomVar]
        public uint SkinId { get; set; }
    }
}