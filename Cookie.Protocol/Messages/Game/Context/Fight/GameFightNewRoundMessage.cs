using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6239)]
    public class GameFightNewRoundMessage
    {
        [CustomVar]
        public uint RoundNumber { get; set; }
    }
}