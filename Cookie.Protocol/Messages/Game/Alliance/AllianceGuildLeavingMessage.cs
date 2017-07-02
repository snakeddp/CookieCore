using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6399)]
    public class AllianceGuildLeavingMessage
    {
        [RegularBool]
        public bool Kicked { get; set; }

        [CustomVar]
        public uint GuildId { get; set; }
    }
}