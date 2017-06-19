
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Mount
{
    [NetworkType(357)]
    public class UpdateMountIntBoost : UpdateMountBoost
    {
        public int Value { get; set; }
    }
}
