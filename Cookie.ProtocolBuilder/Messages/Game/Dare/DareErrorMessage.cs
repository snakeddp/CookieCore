namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6667)]
    public class DareErrorMessage
    {
        public sbyte Error { get; set; }
    }
}