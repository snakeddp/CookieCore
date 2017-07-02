namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(4004)]
    public class FriendAddRequestMessage
    {
        public string Name { get; set; }
    }
}