using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6646)]
    public class TeleportHavenBagAnswerMessage
    {
        [RegularBool]
        public bool Accept { get; set; }
    }
}