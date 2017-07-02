namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6687)]
    public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }
    }
}