using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(301)]
    public class GameRolePlayShowChallengeMessage
    {
        public FightCommonInformations CommonsInfos { get; set; }
    }
}