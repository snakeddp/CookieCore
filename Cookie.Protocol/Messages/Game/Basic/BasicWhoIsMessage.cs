
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Social;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(180)]
    public class BasicWhoIsMessage
    {
        public bool Self { get; set; }
        public byte Position { get; set; }
        public string AccountNickname { get; set; }
        public uint AccountId { get; set; }
        public string PlayerName { get; set; }
        [CustomVar]
        public long PlayerId { get; set; }
        public short AreaId { get; set; }
        public short ServerId { get; set; }
        public short OriginServerId { get; set; }
        public bool Verbose { get; set; }
        public sbyte PlayerState { get; set; }
    }
}
