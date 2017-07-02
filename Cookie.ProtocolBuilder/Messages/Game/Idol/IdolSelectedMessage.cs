namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6581)]
    public class IdolSelectedMessage
    {
        [CustomVar]
        public ushort IdolId { get; set; }

        public bool Activate { get; set; }
        public bool Party { get; set; }
    }
}