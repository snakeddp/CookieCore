using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(5927)]
    public class GameFightOptionStateUpdateMessage
    {
        public ushort FightId { get; set; }
        public sbyte TeamId { get; set; }
        public sbyte Option { get; set; }

        [RegularBool]
        public bool State { get; set; }
    }
}