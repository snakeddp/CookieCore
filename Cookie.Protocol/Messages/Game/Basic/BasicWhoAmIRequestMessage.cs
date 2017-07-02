using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(5664)]
    public class BasicWhoAmIRequestMessage
    {
        [RegularBool]
        public bool Verbose { get; set; }
    }
}