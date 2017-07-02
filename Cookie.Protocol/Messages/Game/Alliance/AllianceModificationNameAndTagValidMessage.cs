using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6449)]
    public class AllianceModificationNameAndTagValidMessage
    {
        public string AllianceName { get; set; }
        public string AllianceTag { get; set; }
    }
}