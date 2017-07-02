namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5748)]
    public class JobAllowMultiCraftRequestMessage
    {
        [RegularBool]
        public bool Enabled { get; set; }
    }
}