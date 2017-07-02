using Cookie.Protocol.Types.Game.Character.Restriction;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(157)]
    public class HumanInformations
    {
        public ActorRestrictionsInformations Restrictions { get; set; }

        [RegularBool]
        public bool Sex { get; set; }
    }
}