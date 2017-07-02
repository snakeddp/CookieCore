namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6327)]
    public class GuildModificationNameValidMessage
    {
        public string GuildName { get; set; }
    }
}