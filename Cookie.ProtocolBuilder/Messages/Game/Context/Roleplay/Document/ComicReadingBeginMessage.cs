namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Document
{
    [NetworkMessage(6536)]
    public class ComicReadingBeginMessage
    {
        [CustomVar]
        public ushort ComicId { get; set; }
    }
}