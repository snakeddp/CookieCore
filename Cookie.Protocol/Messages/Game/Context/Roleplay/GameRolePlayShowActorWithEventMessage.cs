
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6407)]
    public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
    {
        public sbyte ActorEventId { get; set; }
    }
}
