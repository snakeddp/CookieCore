
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1511)]
    public class DownloadCurrentSpeedMessage
    {
        public sbyte DownloadSpeed { get; set; }
    }
}
