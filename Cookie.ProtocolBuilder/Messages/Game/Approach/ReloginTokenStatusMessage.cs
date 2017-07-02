namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(6539)]
    public class ReloginTokenStatusMessage
    {
        [RegularBool]
        public bool ValidToken { get; set; }

        [LengthType(typeof(int), true)]
        public byte[] Ticket { get; set; }
    }
}