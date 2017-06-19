
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Startup;

namespace Cookie.Protocol.Messages.Game.Startup
{
    [NetworkMessage(6538)]
    public class StartupActionAddMessage
    {
        public StartupActionAddObject NewAction { get; set; }
    }
}
