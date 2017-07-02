namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6365)]
    public class TitleSelectRequestMessage
    {
        [CustomVar]
        public ushort TitleId { get; set; }
    }
}