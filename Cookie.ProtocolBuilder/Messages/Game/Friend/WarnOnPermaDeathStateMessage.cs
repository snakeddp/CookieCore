namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6513)]
    public class WarnOnPermaDeathStateMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}