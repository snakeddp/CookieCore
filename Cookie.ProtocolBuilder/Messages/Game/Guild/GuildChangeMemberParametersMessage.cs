namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5549)]
    public class GuildChangeMemberParametersMessage
    {
        [CustomVar]
        public long MemberId { get; set; }

        [CustomVar]
        public ushort Rank { get; set; }

        public sbyte ExperienceGivenPercent { get; set; }

        [CustomVar]
        public uint Rights { get; set; }
    }
}