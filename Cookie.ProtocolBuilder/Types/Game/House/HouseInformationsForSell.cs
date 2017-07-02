namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(221)]
    public class HouseInformationsForSell
    {
        public uint InstanceId { get; set; }

        [RegularBool]
        public bool SecondHand { get; set; }

        [CustomVar]
        public uint ModelId { get; set; }

        public string OwnerName { get; set; }

        [RegularBool]
        public bool OwnerConnected { get; set; }

        public short WorldX { get; set; }
        public short WorldY { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public byte NbRoom { get; set; }
        public byte NbChest { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] SkillListIds { get; set; }

        [RegularBool]
        public bool IsLocked { get; set; }

        [CustomVar]
        public long Price { get; set; }
    }
}