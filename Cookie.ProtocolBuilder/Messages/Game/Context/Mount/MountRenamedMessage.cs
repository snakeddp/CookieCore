namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5983)]
    public class MountRenamedMessage
    {
        [CustomVar]
        public int MountId { get; set; }

        public string Name { get; set; }
    }
}