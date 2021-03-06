﻿using Cookie.Protocol.Types.Game.Character.Choice;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(6551)]
    public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
    {
        public RemodelingInformation Remodel { get; set; }
    }
}