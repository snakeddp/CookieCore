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