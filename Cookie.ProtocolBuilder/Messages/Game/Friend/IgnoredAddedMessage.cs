using Cookie.Protocol.Types.Game.Friend;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5678)]
    public class IgnoredAddedMessage
    {
        public IgnoredInformations IgnoreAdded { get; set; }

        [RegularBool]
        public bool Session { get; set; }
    }
}