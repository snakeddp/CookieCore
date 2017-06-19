
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5975)]
    public class MountInformationInPaddockRequestMessage
    {
        [CustomVar]
        public int MapRideId { get; set; }
    }
}
