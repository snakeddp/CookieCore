using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6622)]
    public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
    {
        public CharacterMinimalInformations OwnerInformations { get; set; }
        public byte Theme { get; set; }
        public sbyte RoomId { get; set; }
        public sbyte MaxRoomId { get; set; }
    }
}