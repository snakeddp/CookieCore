
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Shortcut;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6225)]
    public class ShortcutBarAddRequestMessage
    {
        public sbyte BarType { get; set; }
        public Types.Game.Shortcut.Shortcut Shortcut { get; set; }
    }
}
