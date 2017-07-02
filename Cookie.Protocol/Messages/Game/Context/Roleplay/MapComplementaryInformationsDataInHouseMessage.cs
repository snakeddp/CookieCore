using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.House;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6130)]
    public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
    {
        public HouseInformationsInside CurrentHouse { get; set; }
    }
}