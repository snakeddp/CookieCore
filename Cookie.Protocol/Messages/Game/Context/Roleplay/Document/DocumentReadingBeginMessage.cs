
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Document
{
    [NetworkMessage(5675)]
    public class DocumentReadingBeginMessage
    {
        [CustomVar]
        public ushort DocumentId { get; set; }
    }
}
