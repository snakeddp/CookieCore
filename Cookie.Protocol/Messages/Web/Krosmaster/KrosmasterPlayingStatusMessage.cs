using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6347)]
    public class KrosmasterPlayingStatusMessage
    {
        [RegularBool]
        public bool Playing { get; set; }
    }
}