﻿namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6371)]
    public class TitleLostMessage
    {
        [CustomVar]
        public ushort TitleId { get; set; }
    }
}