namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5606)]
    public class FriendSpouseFollowWithCompassRequestMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}