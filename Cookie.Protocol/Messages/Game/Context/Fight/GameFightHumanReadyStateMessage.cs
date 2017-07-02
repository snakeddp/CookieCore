using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(740)]
    public class GameFightHumanReadyStateMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }

        [RegularBool]
        public bool IsReady { get; set; }
    }
}