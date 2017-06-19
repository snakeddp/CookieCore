
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.House;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6181)]
    public class GuildHouseUpdateInformationMessage
    {
        public HouseInformationsForGuild HousesInformations { get; set; }
    }
}
