﻿namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(882)]
    public class ChatServerCopyMessage : ChatAbstractServerMessage
    {
        [CustomVar]
        public long ReceiverId { get; set; }

        public string ReceiverName { get; set; }
    }
}