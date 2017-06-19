
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6274)]
    public class AbstractPartyMessage
    {
        [CustomVar]
        public uint PartyId { get; set; }
    }
}
