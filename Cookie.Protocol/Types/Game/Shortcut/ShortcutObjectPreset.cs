using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(370)]
    public class ShortcutObjectPreset : ShortcutObject
    {
        public sbyte PresetId { get; set; }
    }
}