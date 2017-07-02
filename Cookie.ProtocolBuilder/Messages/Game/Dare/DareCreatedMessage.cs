using Cookie.Protocol.Types.Game.Dare;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6668)]
    public class DareCreatedMessage
    {
        public DareInformations DareInfos { get; set; }

        [RegularBool]
        public bool NeedNotifications { get; set; }
    }
}