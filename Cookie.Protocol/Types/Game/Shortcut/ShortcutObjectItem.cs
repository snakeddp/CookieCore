
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(371)]
    public class ShortcutObjectItem : ShortcutObject
    {
        public int ItemUID { get; set; }
        public int ItemGID { get; set; }
    }
}
