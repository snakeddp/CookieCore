using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6324)]
    public class GuildModificationStartedMessage
    {
        public bool CanChangeName { get; set; }
        public bool CanChangeEmblem { get; set; }
    }
}