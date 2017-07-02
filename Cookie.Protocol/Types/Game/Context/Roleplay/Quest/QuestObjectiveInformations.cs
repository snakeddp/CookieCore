using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Quest
{
    [NetworkType(385)]
    public class QuestObjectiveInformations
    {
        [CustomVar]
        public ushort ObjectiveId { get; set; }

        [RegularBool]
        public bool ObjectiveStatus { get; set; }

        [LengthType(typeof(short), true)]
        public string[] DialogParams { get; set; }
    }
}