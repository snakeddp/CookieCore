using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5669)]
    public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
    {
        public int MapId { get; set; }

        [CustomVar]
        public uint ElementId { get; set; }
    }
}