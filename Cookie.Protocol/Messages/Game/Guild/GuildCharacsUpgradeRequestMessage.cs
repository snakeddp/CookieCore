using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5706)]
    public class GuildCharacsUpgradeRequestMessage
    {
        public sbyte CharaTypeTarget { get; set; }
    }
}