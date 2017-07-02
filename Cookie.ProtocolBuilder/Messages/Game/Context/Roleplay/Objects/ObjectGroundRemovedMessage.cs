namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Objects
{
    [NetworkMessage(3014)]
    public class ObjectGroundRemovedMessage
    {
        [CustomVar]
        public ushort Cell { get; set; }
    }
}