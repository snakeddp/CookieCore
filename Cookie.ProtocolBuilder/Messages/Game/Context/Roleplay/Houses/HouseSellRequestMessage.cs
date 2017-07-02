namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5697)]
    public class HouseSellRequestMessage
    {
        public uint InstanceId { get; set; }

        [CustomVar]
        public long Amount { get; set; }

        [RegularBool]
        public bool ForSale { get; set; }
    }
}