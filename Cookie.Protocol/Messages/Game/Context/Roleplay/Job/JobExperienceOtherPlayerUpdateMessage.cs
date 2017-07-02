using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(6599)]
    public class JobExperienceOtherPlayerUpdateMessage : JobExperienceUpdateMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }
    }
}