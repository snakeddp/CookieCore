
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6381)]
    public class AchievementFinishedInformationMessage : AchievementFinishedMessage
    {
        public string Name { get; set; }
        [CustomVar]
        public long PlayerId { get; set; }
    }
}
