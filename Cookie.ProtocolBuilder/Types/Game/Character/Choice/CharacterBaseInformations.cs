﻿namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(45)]
    public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
    {
        public byte Breed { get; set; }

        [RegularBool]
        public bool Sex { get; set; }
    }
}