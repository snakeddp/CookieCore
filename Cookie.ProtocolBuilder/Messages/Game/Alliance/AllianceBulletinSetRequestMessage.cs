namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6693)]
    public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public string Content { get; set; }

        [RegularBool]
        public bool NotifyMembers { get; set; }
    }
}