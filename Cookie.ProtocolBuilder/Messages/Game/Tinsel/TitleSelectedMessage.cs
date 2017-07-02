namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6366)]
    public class TitleSelectedMessage
    {
        [CustomVar]
        public ushort TitleId { get; set; }
    }
}