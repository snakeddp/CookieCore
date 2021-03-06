﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(151)]
    public class CharactersListMessage : BasicCharactersListMessage
    {
        [RegularBool]
        public bool HasStartupActions { get; set; }
    }
}