namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5671)]
    public class LockableStateUpdateAbstractMessage
    {
        [RegularBool]
        public bool Locked { get; set; }
    }
}