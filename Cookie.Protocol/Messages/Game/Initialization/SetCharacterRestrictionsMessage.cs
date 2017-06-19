
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Restriction;

namespace Cookie.Protocol.Messages.Game.Initialization
{
    [NetworkMessage(170)]
    public class SetCharacterRestrictionsMessage
    {
        public double ActorId { get; set; }
        public ActorRestrictionsInformations Restrictions { get; set; }
    }
}
