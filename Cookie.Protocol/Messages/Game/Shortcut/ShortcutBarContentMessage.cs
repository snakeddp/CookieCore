
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Shortcut;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6231)]
    public class ShortcutBarContentMessage
    {
        public sbyte BarType { get; set; }
    }
}
