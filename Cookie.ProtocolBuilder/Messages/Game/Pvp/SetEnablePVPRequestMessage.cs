namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(1810)]
    public class SetEnablePVPRequestMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}