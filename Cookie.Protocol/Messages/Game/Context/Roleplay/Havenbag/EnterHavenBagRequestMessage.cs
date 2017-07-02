using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6636)]
    public class EnterHavenBagRequestMessage
    {
        [CustomVar]
        public long HavenBagOwner { get; set; }
    }
}