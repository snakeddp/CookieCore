using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Quest;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(383)]
    public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
    {
        public GameRolePlayNpcQuestFlag QuestFlag { get; set; }
    }
}