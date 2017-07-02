using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SequenceTypeEnum
    {
        SequenceSpell = 1,
        SequenceWeapon = 2,
        SequenceGlyphTrap = 3,
        SequenceTriggered = 4,
        SequenceMove = 5,
        SequenceCharacterDeath = 6,
        SequenceTurnStart = 7,
        SequenceTurnEnd = 8,
        SequenceFightStart = 9
    }
}