namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5602)]
    public class FriendSetWarnOnConnectionMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}