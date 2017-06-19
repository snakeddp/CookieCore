
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(5822)]
    public class GameRolePlayFightRequestCanceledMessage
    {
        public int FightId { get; set; }
        public double SourceId { get; set; }
        public double TargetId { get; set; }
    }
}
