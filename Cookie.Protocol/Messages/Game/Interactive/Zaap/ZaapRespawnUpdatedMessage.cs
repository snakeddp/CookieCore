using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Interactive.Zaap
{
    [NetworkMessage(6571)]
    public class ZaapRespawnUpdatedMessage
    {
        public uint MapId { get; set; }
    }
}