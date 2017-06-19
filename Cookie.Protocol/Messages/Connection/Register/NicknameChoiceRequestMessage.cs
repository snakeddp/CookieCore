
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Connection.Register
{
    [NetworkMessage(5639)]
    public class NicknameChoiceRequestMessage
    {
        public string Nickname { get; set; }
    }
}
