﻿namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(472)]
    public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
    {
        public sbyte Direction { get; set; }

        [CustomVar]
        public ushort NpcId { get; set; }
    }
}