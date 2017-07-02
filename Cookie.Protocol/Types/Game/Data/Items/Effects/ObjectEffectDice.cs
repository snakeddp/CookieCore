using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(73)]
    public class ObjectEffectDice : ObjectEffect
    {
        [CustomVar]
        public ushort DiceNum { get; set; }

        [CustomVar]
        public ushort DiceSide { get; set; }

        [CustomVar]
        public ushort DiceConst { get; set; }
    }
}