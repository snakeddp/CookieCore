using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6229)]
    public class ShortcutBarRefreshMessage
    {
        public sbyte BarType { get; set; }
        public Types.Game.Shortcut.Shortcut Shortcut { get; set; }
    }
}