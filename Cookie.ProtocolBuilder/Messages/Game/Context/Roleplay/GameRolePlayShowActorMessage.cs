using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(5632)]
    public class GameRolePlayShowActorMessage
    {
        public GameRolePlayActorInformations Informations { get; set; }
    }
}