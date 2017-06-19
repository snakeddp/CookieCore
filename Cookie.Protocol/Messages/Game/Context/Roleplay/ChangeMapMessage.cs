
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(221)]
    public class ChangeMapMessage
    {
        public uint MapId { get; set; }
    }
}
