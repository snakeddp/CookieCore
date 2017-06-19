
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5554)]
    public class GuildCreationResultMessage
    {
        public sbyte Result { get; set; }
    }
}
