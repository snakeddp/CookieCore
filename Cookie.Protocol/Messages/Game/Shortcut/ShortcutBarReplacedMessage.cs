using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6706)]
    public class ShortcutBarReplacedMessage
    {
        public sbyte BarType { get; set; }
        public Types.Game.Shortcut.Shortcut Shortcut { get; set; }
    }
}