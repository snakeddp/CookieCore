﻿
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(464)]
    public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
    {
        public sbyte NbWaves { get; set; }
    }
}
