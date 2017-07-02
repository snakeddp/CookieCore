namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(380)]
    public class AbstractContactInformations
    {
        public uint AccountId { get; set; }
        public string AccountName { get; set; }
    }
}