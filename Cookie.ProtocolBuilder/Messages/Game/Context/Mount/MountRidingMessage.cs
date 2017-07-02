namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5967)]
    public class MountRidingMessage
    {
        [RegularBool]
        public bool IsRiding { get; set; }
    }
}