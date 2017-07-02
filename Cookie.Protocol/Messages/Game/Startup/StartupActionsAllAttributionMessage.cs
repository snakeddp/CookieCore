using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Startup
{
    [NetworkMessage(6537)]
    public class StartupActionsAllAttributionMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }
    }
}