using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(6191)]
    public class GameRolePlayAttackMonsterRequestMessage
    {
        public double MonsterGroupId { get; set; }
    }
}