
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.House;
using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Interactive;
using Cookie.Protocol.Types.Game.Interactive;
using Cookie.Protocol.Types.Game.Interactive;
using Cookie.Protocol.Types.Game.Context.Fight;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(226)]
    public class MapComplementaryInformationsDataMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
        public uint MapId { get; set; }
        [RegularBool]
        public bool HasAggressiveMonsters { get; set; }
        public FightStartingPositions FightStartPositions { get; set; }
    }
}
