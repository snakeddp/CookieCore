using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6645)]
    public class InviteInHavenBagClosedMessage
    {
        public CharacterMinimalInformations HostInformations { get; set; }
    }
}