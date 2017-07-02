namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Death
{
    [NetworkMessage(6512)]
    public class WarnOnPermaDeathMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}