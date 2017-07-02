namespace Cookie.Protocol.Messages.Game.Ui
{
    [NetworkMessage(6459)]
    public class ClientUIOpenedMessage
    {
        public sbyte Type { get; set; }
    }
}