using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(90)]
    public class PartyMemberInformations : CharacterBaseInformations
    {
        [CustomVar]
        public uint LifePoints { get; set; }

        [CustomVar]
        public uint MaxLifePoints { get; set; }

        [CustomVar]
        public ushort Prospecting { get; set; }

        public sbyte RegenRate { get; set; }

        [CustomVar]
        public ushort Initiative { get; set; }

        public byte AlignmentSide { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public PlayerStatus Status { get; set; }
    }
}