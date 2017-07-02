using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6444)]
    public class AllianceModificationStartedMessage
    {
        public bool CanChangeName { get; set; }
        public bool CanChangeTag { get; set; }
        public bool CanChangeEmblem { get; set; }
    }
}