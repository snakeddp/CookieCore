namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6115)]
    public class GuildInvitationByNameMessage
    {
        public string Name { get; set; }
    }
}