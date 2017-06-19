
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(711)]
    public class GameFightRemoveTeamMemberMessage
    {
        public ushort FightId { get; set; }
        public sbyte TeamId { get; set; }
        public double CharId { get; set; }
    }
}
