using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6224)]
    public class ShortcutBarRemovedMessage
    {
        public sbyte BarType { get; set; }
        public sbyte Slot { get; set; }
    }
}