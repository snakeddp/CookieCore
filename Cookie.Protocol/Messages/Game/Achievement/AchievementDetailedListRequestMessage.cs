using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Achievement
{
    [NetworkMessage(6357)]
    public class AchievementDetailedListRequestMessage
    {
        [CustomVar]
        public ushort CategoryId { get; set; }
    }
}