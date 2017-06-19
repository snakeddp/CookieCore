
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6474)]
    public class GameFightSpectatePlayerRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
