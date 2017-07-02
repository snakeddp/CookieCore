namespace Cookie.Protocol.Messages.Game.Guest
{
    [NetworkMessage(6505)]
    public class GuestModeMessage
    {
        [RegularBool]
        public bool Active { get; set; }
    }
}