using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6716)]
    public class MapFightStartPositionsUpdateMessage
    {
        public uint MapId { get; set; }
        public FightStartingPositions FightStartPositions { get; set; }
    }
}