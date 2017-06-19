﻿
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Creation
{
    [NetworkMessage(6733)]
    public class CharacterCanBeCreatedResultMessage
    {
        [RegularBool]
        public bool YesYouCan { get; set; }
    }
}
