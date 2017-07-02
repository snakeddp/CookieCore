namespace Cookie.Protocol.Messages.Common.Basic
{
    [NetworkMessage(183)]
    public class BasicPongMessage
    {
        [RegularBool]
        public bool Quiet { get; set; }
    }
}