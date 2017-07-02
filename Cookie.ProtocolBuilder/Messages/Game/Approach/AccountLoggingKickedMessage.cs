namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(6029)]
    public class AccountLoggingKickedMessage
    {
        [CustomVar]
        public ushort Days { get; set; }

        public sbyte Hours { get; set; }
        public sbyte Minutes { get; set; }
    }
}