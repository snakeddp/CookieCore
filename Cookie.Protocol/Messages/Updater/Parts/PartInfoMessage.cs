
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Updater;

namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1508)]
    public class PartInfoMessage
    {
        public ContentPart Part { get; set; }
        public float InstallationPercent { get; set; }
    }
}
