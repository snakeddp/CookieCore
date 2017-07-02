namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6369)]
    public class OrnamentSelectedMessage
    {
        [CustomVar]
        public ushort OrnamentId { get; set; }
    }
}