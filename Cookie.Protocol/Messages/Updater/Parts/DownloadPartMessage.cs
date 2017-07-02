using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1503)]
    public class DownloadPartMessage
    {
        public string Id { get; set; }
    }
}