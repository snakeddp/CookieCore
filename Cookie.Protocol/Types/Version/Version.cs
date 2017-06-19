
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Version
{
    [NetworkType(11)]
    public class Version
    {
        public sbyte Major { get; set; }
        public sbyte Minor { get; set; }
        public sbyte Release { get; set; }
        public uint Revision { get; set; }
        public sbyte Patch { get; set; }
        public sbyte BuildType { get; set; }
    }
}
