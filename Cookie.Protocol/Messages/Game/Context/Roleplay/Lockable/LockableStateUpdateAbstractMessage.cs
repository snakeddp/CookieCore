using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5671)]
    public class LockableStateUpdateAbstractMessage
    {
        [RegularBool]
        public bool Locked { get; set; }
    }
}