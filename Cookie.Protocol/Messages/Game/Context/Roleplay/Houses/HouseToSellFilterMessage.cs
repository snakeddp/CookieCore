using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(6137)]
    public class HouseToSellFilterMessage
    {
        public int AreaId { get; set; }
        public sbyte AtLeastNbRoom { get; set; }
        public sbyte AtLeastNbChest { get; set; }

        [CustomVar]
        public ushort SkillRequested { get; set; }

        [CustomVar]
        public long MaxPrice { get; set; }
    }
}