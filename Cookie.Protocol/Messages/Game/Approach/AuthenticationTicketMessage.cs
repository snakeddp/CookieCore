using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(110)]
    public class AuthenticationTicketMessage
    {
        public string Lang { get; set; }
        public string Ticket { get; set; }
    }
}