namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5680)]
    public class IgnoredDeleteRequestMessage
    {
        public uint AccountId { get; set; }

        [RegularBool]
        public bool Session { get; set; }
    }
}