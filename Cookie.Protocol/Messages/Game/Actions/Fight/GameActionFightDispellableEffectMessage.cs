using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Actions.Fight;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6070)]
    public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
    {
        public AbstractFightDispellableEffect Effect { get; set; }
    }
}