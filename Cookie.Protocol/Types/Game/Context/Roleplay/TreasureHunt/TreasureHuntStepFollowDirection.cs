
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(468)]
    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        public sbyte Direction { get; set; }
        [CustomVar]
        public ushort MapCount { get; set; }
    }
}
