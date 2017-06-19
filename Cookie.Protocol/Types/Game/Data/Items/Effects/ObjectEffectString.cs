
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(74)]
    public class ObjectEffectString : ObjectEffect
    {
        public string Value { get; set; }
    }
}
