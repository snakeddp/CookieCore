namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1512)]
    public class DownloadSetSpeedRequestMessage
    {
        public sbyte DownloadSpeed { get; set; }
    }
}