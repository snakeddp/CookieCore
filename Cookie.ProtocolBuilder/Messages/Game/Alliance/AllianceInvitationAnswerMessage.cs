namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6401)]
    public class AllianceInvitationAnswerMessage
    {
        [RegularBool]
        public bool Accept { get; set; }
    }
}