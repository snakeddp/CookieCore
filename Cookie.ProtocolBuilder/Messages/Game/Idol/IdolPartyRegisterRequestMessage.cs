﻿namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6582)]
    public class IdolPartyRegisterRequestMessage
    {
        [RegularBool]
        public bool Register { get; set; }
    }
}