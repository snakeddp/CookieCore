﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6724)]
    public class FollowQuestObjectiveRequestMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }

        public short ObjectiveId { get; set; }
    }
}