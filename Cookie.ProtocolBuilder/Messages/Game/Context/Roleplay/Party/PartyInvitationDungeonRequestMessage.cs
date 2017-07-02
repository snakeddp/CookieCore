﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6245)]
    public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}