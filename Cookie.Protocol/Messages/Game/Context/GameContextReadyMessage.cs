
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(6071)]
    public class GameContextReadyMessage
    {
        public uint MapId { get; set; }
    }
}
