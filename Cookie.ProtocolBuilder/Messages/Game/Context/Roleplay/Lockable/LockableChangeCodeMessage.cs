namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5666)]
    public class LockableChangeCodeMessage
    {
        public string Code { get; set; }
    }
}