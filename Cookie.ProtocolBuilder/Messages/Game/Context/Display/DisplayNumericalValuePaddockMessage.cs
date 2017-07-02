namespace Cookie.Protocol.Messages.Game.Context.Display
{
    [NetworkMessage(6563)]
    public class DisplayNumericalValuePaddockMessage
    {
        public int RideId { get; set; }
        public int Value { get; set; }
        public sbyte Type { get; set; }
    }
}