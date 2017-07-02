namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6404)]
    public class GuildFactsRequestMessage
    {
        [CustomVar]
        public uint GuildId { get; set; }
    }
}