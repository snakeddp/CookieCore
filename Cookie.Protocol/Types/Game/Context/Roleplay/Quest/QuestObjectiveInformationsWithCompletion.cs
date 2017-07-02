using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Quest
{
    [NetworkType(386)]
    public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
    {
        [CustomVar]
        public ushort CurCompletion { get; set; }

        [CustomVar]
        public ushort MaxCompletion { get; set; }
    }
}