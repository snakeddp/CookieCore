namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5601)]
    public class FriendDeleteResultMessage
    {
        [RegularBool]
        public bool Success { get; set; }

        public string Name { get; set; }
    }
}