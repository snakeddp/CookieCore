namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6666)]
    public class DareSubscribeRequestMessage
    {
        public double DareId { get; set; }

        [RegularBool]
        public bool Subscribe { get; set; }
    }
}