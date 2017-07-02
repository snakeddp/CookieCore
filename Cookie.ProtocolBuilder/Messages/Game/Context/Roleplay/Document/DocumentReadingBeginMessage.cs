namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Document
{
    [NetworkMessage(5675)]
    public class DocumentReadingBeginMessage
    {
        [CustomVar]
        public ushort DocumentId { get; set; }
    }
}