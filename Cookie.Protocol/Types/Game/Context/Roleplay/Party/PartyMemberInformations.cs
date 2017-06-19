
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Choice;
using Cookie.Protocol.Types.Game.Character.Status;
using Cookie.Protocol.Types.Game.Context.Roleplay.Party.Companion;

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
