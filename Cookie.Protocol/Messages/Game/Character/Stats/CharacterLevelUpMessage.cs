using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(5670)]
    public class CharacterLevelUpMessage
    {
        public sbyte NewLevel { get; set; }
    }
}