using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Paddock;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5952)]
    public class GuildPaddockBoughtMessage
    {
        public PaddockContentInformations PaddockInfo { get; set; }
    }
}