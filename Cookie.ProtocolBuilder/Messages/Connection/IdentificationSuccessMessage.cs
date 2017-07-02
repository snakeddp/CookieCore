namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(22)]
    public class IdentificationSuccessMessage
    {
        public string Login { get; set; }
        public string Nickname { get; set; }
        public uint AccountId { get; set; }
        public sbyte CommunityId { get; set; }
        public bool HasRights { get; set; }
        public string SecretQuestion { get; set; }
        public double AccountCreation { get; set; }
        public double SubscriptionElapsedDuration { get; set; }
        public double SubscriptionEndDate { get; set; }
        public bool WasAlreadyConnected { get; set; }
        public sbyte HavenbagAvailableRoom { get; set; }
    }
}