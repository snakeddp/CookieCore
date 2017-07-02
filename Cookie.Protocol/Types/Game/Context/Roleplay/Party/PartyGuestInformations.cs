using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Status;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(374)]
    public class PartyGuestInformations
    {
        [CustomVar]
        public long GuestId { get; set; }

        [CustomVar]
        public long HostId { get; set; }

        public string Name { get; set; }
        public EntityLook GuestLook { get; set; }
        public byte Breed { get; set; }

        [RegularBool]
        public bool Sex { get; set; }

        public PlayerStatus Status { get; set; }
    }
}