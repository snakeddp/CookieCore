﻿using Cookie.Protocol.Types.Game.Fight;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(443)]
    public class PrismFightersInformation
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
    }
}