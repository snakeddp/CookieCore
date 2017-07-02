using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(253)]
    public class GameContextMoveElementMessage
    {
        public EntityMovementInformations Movement { get; set; }
    }
}