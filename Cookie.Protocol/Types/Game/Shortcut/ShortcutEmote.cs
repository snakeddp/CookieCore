using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(389)]
    public class ShortcutEmote : Shortcut
    {
        public sbyte EmoteId { get; set; }
    }
}