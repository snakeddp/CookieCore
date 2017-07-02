using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5550)]
    public class GuildGetInformationsMessage
    {
        public sbyte InfoType { get; set; }
    }
}