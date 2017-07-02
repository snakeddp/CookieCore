using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Social
{
    [NetworkMessage(5933)]
    public class ContactLookRequestByNameMessage : ContactLookRequestMessage
    {
        public string PlayerName { get; set; }
    }
}