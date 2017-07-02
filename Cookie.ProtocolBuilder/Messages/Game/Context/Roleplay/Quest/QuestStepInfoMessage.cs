using Cookie.Protocol.Types.Game.Context.Roleplay.Quest;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(5625)]
    public class QuestStepInfoMessage
    {
        public QuestActiveInformations Infos { get; set; }
    }
}