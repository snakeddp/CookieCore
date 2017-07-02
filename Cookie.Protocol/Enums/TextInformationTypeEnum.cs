using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TextInformationTypeEnum
    {
        TextInformationMessage = 0,
        TextInformationError = 1,
        TextInformationPvp = 2,
        TextInformationFightLog = 3,
        TextInformationPopup = 4,
        TextLivingObject = 5,
        TextEntityTalk = 6,
        TextInformationFight = 7
    }
}