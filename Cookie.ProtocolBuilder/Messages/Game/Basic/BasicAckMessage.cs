namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6362)]
    public class BasicAckMessage
    {
        [CustomVar]
        public uint Seq { get; set; }

        [CustomVar]
        public ushort LastPacketId { get; set; }
    }
}