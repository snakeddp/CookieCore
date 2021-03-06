﻿namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(950)]
    public class GameMapMovementRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] KeyMovements { get; set; }

        public uint MapId { get; set; }
    }
}