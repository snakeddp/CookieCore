using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(210)]
    public class MapFightCountMessage
    {
        [CustomVar]
        public ushort FightCount { get; set; }
    }
}