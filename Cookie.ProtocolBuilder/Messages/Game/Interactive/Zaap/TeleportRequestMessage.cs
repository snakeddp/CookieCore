namespace Cookie.Protocol.Messages.Game.Interactive.Zaap
{
    [NetworkMessage(5961)]
    public class TeleportRequestMessage
    {
        public sbyte TeleporterType { get; set; }
        public uint MapId { get; set; }
    }
}