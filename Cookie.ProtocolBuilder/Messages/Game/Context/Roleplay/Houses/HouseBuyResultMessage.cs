namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5735)]
    public class HouseBuyResultMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        public uint InstanceId { get; set; }
        public bool SecondHand { get; set; }
        public bool Bought { get; set; }

        [CustomVar]
        public long RealPrice { get; set; }
    }
}