
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6441)]
    public class PrismsListRegisterMessage
    {
        public sbyte Listen { get; set; }
    }
}
