using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6545)]
    public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
    {
        public short MarkId { get; set; }

        [RegularBool]
        public bool Active { get; set; }
    }
}