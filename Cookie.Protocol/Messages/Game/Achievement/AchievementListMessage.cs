
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Achievement;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6205)]
    public class AchievementListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] FinishedAchievementsIds { get; set; }
    }
}
