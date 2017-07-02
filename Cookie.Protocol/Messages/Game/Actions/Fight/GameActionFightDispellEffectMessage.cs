using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6113)]
    public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
    {
        public uint BoostUID { get; set; }
    }
}