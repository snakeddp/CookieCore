
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Shortcut;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6229)]
    public class ShortcutBarRefreshMessage
    {
        public sbyte BarType { get; set; }
        public Types.Game.Shortcut.Shortcut Shortcut { get; set; }
    }
}
