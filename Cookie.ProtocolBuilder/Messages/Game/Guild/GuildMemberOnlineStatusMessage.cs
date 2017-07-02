namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6061)]
    public class GuildMemberOnlineStatusMessage
    {
        [CustomVar]
        public long MemberId { get; set; }

        [RegularBool]
        public bool Online { get; set; }
    }
}