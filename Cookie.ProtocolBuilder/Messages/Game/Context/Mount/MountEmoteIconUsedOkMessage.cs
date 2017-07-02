namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5978)]
    public class MountEmoteIconUsedOkMessage
    {
        [CustomVar]
        public int MountId { get; set; }

        public sbyte ReactionType { get; set; }
    }
}