using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5673)]
    public class IgnoredAddRequestMessage
    {
        public string Name { get; set; }

        [RegularBool]
        public bool Session { get; set; }
    }
}