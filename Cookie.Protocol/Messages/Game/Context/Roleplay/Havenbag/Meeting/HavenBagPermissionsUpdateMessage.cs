
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6713)]
    public class HavenBagPermissionsUpdateMessage
    {
        public uint Permissions { get; set; }
    }
}
