using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Initialization
{
    [NetworkMessage(6237)]
    public class ServerExperienceModificatorMessage
    {
        [CustomVar]
        public ushort ExperiencePercent { get; set; }
    }
}