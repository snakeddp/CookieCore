using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Updater.Parts
{
    [NetworkMessage(1513)]
    public class DownloadErrorMessage
    {
        public sbyte ErrorId { get; set; }
        public string Message { get; set; }
        public string HelpUrl { get; set; }
    }
}