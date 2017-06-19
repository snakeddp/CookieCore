
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Version
{
    [NetworkType(393)]
    public class VersionExtended : Version
    {
        public sbyte Install { get; set; }
        public sbyte Technology { get; set; }
    }
}
