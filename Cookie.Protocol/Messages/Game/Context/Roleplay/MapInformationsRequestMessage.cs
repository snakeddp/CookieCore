
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(225)]
    public class MapInformationsRequestMessage
    {
        public uint MapId { get; set; }
    }
}
