using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Job
{
    [NetworkType(194)]
    public class JobCrafterDirectoryEntryPlayerInfo
    {
        [CustomVar]
        public long PlayerId { get; set; }

        public string PlayerName { get; set; }
        public byte AlignmentSide { get; set; }
        public byte Breed { get; set; }

        [RegularBool]
        public bool Sex { get; set; }

        [RegularBool]
        public bool IsInWorkshop { get; set; }

        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public PlayerStatus Status { get; set; }
    }
}