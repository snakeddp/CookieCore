namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(511)]
    public class HouseInstanceInformations
    {
        public uint InstanceId { get; set; }
        public bool SecondHand { get; set; }
        public bool IsLocked { get; set; }
        public string OwnerName { get; set; }

        [CustomVar]
        public long Price { get; set; }

        public bool IsSaleLocked { get; set; }
    }
}