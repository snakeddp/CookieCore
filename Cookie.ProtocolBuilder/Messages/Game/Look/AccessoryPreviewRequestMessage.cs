namespace Cookie.Protocol.Messages.Game.Look
{
    [NetworkMessage(6518)]
    public class AccessoryPreviewRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] GenericId { get; set; }
    }
}