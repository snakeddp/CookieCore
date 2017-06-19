
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay.Quest;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Quest
{
    [NetworkType(382)]
    public class QuestActiveDetailedInformations : QuestActiveInformations
    {
        [CustomVar]
        public ushort StepId { get; set; }
    }
}
