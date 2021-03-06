﻿using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(150)]
    public class GameContextActorInformations
    {
        public double ContextualId { get; set; }
        public EntityLook Look { get; set; }
        public EntityDispositionInformations Disposition { get; set; }
    }
}