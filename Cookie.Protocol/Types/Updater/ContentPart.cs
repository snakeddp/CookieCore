
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Updater
{
    [NetworkType(350)]
    public class ContentPart
    {
        public string Id { get; set; }
        public sbyte State { get; set; }
    }
}
