using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(6068)]
    public class CharacterSelectedForceMessage
    {
        public int Id { get; set; }
    }
}