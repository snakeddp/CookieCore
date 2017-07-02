namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5630)]
    public class FriendWarnOnConnectionStateMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}