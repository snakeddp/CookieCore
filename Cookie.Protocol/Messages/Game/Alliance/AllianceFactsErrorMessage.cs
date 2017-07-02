using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6423)]
    public class AllianceFactsErrorMessage
    {
        [CustomVar]
        public uint AllianceId { get; set; }
    }
}