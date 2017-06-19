
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Look
{
    [NetworkMessage(6521)]
    public class AccessoryPreviewErrorMessage
    {
        public sbyte Error { get; set; }
    }
}
