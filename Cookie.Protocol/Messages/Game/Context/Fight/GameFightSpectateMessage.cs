
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Action.Fight;
using Cookie.Protocol.Types.Game.Actions.Fight;
using Cookie.Protocol.Types.Game.Idol;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6069)]
    public class GameFightSpectateMessage
    {
        [CustomVar]
        public ushort GameTurn { get; set; }
        public uint FightStart { get; set; }
    }
}
