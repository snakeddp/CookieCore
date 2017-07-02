using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(461)]
    public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
    {
        public sbyte Direction { get; set; }

        [CustomVar]
        public ushort PoiLabelId { get; set; }
    }
}