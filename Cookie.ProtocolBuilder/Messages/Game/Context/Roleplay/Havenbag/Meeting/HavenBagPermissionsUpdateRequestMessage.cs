namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    [NetworkMessage(6714)]
    public class HavenBagPermissionsUpdateRequestMessage
    {
        public uint Permissions { get; set; }
    }
}