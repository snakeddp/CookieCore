using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Interactive.Zaap
{
    [NetworkMessage(1604)]
    public class ZaapListMessage : TeleportDestinationsListMessage
    {
        public uint SpawnMapId { get; set; }
    }
}