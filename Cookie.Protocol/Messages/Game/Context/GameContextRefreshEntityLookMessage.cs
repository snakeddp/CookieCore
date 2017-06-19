
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(5637)]
    public class GameContextRefreshEntityLookMessage
    {
        public double Id { get; set; }
        public EntityLook Look { get; set; }
    }
}
