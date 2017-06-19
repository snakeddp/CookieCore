
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6498)]
    public class TreasureHuntShowLegendaryUIMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] AvailableLegendaryIds { get; set; }
    }
}
