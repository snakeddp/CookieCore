namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5955)]
    public class GuildPaddockRemovedMessage
    {
        public int PaddockId { get; set; }
    }
}