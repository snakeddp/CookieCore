using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6642)]
    public class InviteInHavenBagMessage
    {
        public CharacterMinimalInformations GuestInformations { get; set; }

        [RegularBool]
        public bool Accept { get; set; }
    }
}