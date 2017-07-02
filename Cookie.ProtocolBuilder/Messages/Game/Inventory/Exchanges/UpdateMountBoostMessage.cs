namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6179)]
    public class UpdateMountBoostMessage
    {
        [CustomVar]
        public int RideId { get; set; }
    }
}