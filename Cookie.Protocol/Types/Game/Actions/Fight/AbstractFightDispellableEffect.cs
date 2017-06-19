
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(206)]
    public class AbstractFightDispellableEffect
    {
        [CustomVar]
        public uint Uid { get; set; }
        public double TargetId { get; set; }
        public short TurnDuration { get; set; }
        public sbyte Dispelable { get; set; }
        [CustomVar]
        public ushort SpellId { get; set; }
        [CustomVar]
        public uint EffectId { get; set; }
        [CustomVar]
        public uint ParentBoostUid { get; set; }
    }
}
