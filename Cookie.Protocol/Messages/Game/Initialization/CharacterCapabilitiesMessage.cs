using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Initialization
{
    [NetworkMessage(6339)]
    public class CharacterCapabilitiesMessage
    {
        [CustomVar]
        public uint GuildEmblemSymbolCategories { get; set; }
    }
}