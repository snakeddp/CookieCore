
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Deletion
{
    [NetworkMessage(166)]
    public class CharacterDeletionErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}
