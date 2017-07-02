using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5667)]
    public class LockableUseCodeMessage
    {
        public string Code { get; set; }
    }
}