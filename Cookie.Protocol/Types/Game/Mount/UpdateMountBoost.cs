
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Mount
{
    [NetworkType(356)]
    public class UpdateMountBoost
    {
        public sbyte Type { get; set; }
    }
}
