using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(952)]
    public class GameMapMovementConfirmMessage
    {
        public int MapId { get; set; }

        [CustomVar]
        public long CharacterId { get; set; }
    }
}