namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(6684)]
    public class SocialNoticeSetErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}