using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Enums;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(22, Origin.Server)]
    public class IdentificationSucessMessage
    {
        [ForceNewByte]
        public bool HasRights { get; set; }
        public bool WasAlreadyConnected { get; set; }

        public string Login { get; set; }
        public string Nickname { get; set; }
        public int AccountId { get; set; }
        public byte CommunityId { get; set; }
        public string SecretQuestion { get; set; }
        public double AccountCreation { get; set; }
        public double SubscriptionElapsedDuration { get; set; }
        public double SubscriptionEndDate { get; set; }
        public byte HavenbagAvailableRoom { get; set; }
    }
}
