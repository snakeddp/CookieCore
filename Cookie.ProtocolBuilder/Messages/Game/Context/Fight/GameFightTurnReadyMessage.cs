﻿namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(716)]
    public class GameFightTurnReadyMessage
    {
        [RegularBool]
        public bool IsReady { get; set; }
    }
}