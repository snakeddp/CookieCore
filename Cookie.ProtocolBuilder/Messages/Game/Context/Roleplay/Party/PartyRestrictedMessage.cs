﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6175)]
    public class PartyRestrictedMessage : AbstractPartyMessage
    {
        [RegularBool]
        public bool Restricted { get; set; }
    }
}