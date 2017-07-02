namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses.Guild
{
    [NetworkMessage(5701)]
    public class HouseGuildNoneMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        public uint InstanceId { get; set; }

        [RegularBool]
        public bool SecondHand { get; set; }
    }
}