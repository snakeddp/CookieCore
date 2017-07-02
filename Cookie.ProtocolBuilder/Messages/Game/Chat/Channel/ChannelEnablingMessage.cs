﻿namespace Cookie.Protocol.Messages.Game.Chat.Channel
{
    [NetworkMessage(890)]
    public class ChannelEnablingMessage
    {
        public sbyte Channel { get; set; }

        [RegularBool]
        public bool Enable { get; set; }
    }
}