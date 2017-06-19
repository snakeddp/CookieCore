
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(6443)]
    public class SetEnableAVARequestMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}
