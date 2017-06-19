
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(6305)]
    public class ServerOptionalFeaturesMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] Features { get; set; }
    }
}
