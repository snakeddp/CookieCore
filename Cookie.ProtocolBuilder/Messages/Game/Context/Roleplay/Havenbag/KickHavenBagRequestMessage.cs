namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6652)]
    public class KickHavenBagRequestMessage
    {
        [CustomVar]
        public long GuestId { get; set; }
    }
}