using Cookie.Protocol.Types.Game.Character.Choice;

namespace Cookie.Protocol.Messages.Game.Character.Choice
{
    [NetworkMessage(153)]
    public class CharacterSelectedSuccessMessage
    {
        public CharacterBaseInformations Infos { get; set; }

        [RegularBool]
        public bool IsCollectingStats { get; set; }
    }
}