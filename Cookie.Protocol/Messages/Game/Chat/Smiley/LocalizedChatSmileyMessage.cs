using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Chat.Smiley
{
    [NetworkMessage(6185)]
    public class LocalizedChatSmileyMessage : ChatSmileyMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}