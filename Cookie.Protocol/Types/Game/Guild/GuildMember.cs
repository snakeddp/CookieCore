
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character;
using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Types.Game.Guild
{
    [NetworkType(88)]
    public class GuildMember : CharacterMinimalInformations
    {
        public byte Breed { get; set; }
        public bool Sex { get; set; }
        [CustomVar]
        public ushort Rank { get; set; }
        [CustomVar]
        public long GivenExperience { get; set; }
        public sbyte ExperienceGivenPercent { get; set; }
        [CustomVar]
        public uint Rights { get; set; }
        public sbyte Connected { get; set; }
        public byte AlignmentSide { get; set; }
        public ushort HoursSinceLastConnection { get; set; }
        [CustomVar]
        public ushort MoodSmileyId { get; set; }
        public uint AccountId { get; set; }
        public int AchievementPoints { get; set; }
        public PlayerStatus Status { get; set; }
        public bool HavenBagShared { get; set; }
    }
}
