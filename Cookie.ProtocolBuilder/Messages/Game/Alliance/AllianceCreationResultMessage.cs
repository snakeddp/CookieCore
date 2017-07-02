namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6391)]
    public class AllianceCreationResultMessage
    {
        public sbyte Result { get; set; }
    }
}