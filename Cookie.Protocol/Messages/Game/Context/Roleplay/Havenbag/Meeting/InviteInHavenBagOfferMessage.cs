using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6643)]
    public class InviteInHavenBagOfferMessage
    {
        public CharacterMinimalInformations HostInformations { get; set; }

        [CustomVar]
        public int TimeLeftBeforeCancel { get; set; }
    }
}