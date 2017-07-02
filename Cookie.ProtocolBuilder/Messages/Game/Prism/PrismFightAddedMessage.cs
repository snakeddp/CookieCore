using Cookie.Protocol.Types.Game.Prism;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6452)]
    public class PrismFightAddedMessage
    {
        public PrismFightersInformation Fight { get; set; }
    }
}