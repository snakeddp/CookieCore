﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6097)]
    public class QuestValidatedMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
    }
}