﻿namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6409)]
    public class AllianceFactsRequestMessage
    {
        [CustomVar]
        public uint AllianceId { get; set; }
    }
}