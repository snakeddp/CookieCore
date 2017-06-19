
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(92)]
    public class FriendOnlineInformations : FriendInformations
    {
        [CustomVar]
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public sbyte Level { get; set; }
        public byte AlignmentSide { get; set; }
        public byte Breed { get; set; }
        public bool Sex { get; set; }
        public GuildInformations GuildInfo { get; set; }
        [CustomVar]
        public ushort MoodSmileyId { get; set; }
        public PlayerStatus Status { get; set; }
        public bool HavenBagShared { get; set; }
    }
}
