namespace Cookie.Protocol.Messages.Game.Ui
{
    [NetworkMessage(6463)]
    public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
    {
        [CustomVar]
        public uint Uid { get; set; }
    }
}