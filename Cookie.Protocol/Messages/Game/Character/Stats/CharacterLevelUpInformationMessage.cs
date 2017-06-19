﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(6076)]
    public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
    {
        public string Name { get; set; }
        [CustomVar]
        public long Id { get; set; }
    }
}
