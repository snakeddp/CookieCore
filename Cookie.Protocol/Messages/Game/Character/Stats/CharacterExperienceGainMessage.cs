using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(6321)]
    public class CharacterExperienceGainMessage
    {
        [CustomVar]
        public long ExperienceCharacter { get; set; }

        [CustomVar]
        public long ExperienceMount { get; set; }

        [CustomVar]
        public long ExperienceGuild { get; set; }

        [CustomVar]
        public long ExperienceIncarnation { get; set; }
    }
}