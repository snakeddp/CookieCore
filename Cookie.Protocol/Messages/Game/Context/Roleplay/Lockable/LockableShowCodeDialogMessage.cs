using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5740)]
    public class LockableShowCodeDialogMessage
    {
        [RegularBool]
        public bool ChangeOrUse { get; set; }

        public sbyte CodeSize { get; set; }
    }
}