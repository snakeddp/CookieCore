namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6364)]
    public class TitleGainedMessage
    {
        [CustomVar]
        public ushort TitleId { get; set; }
    }
}