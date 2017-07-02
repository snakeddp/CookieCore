namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5747)]
    public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Skills { get; set; }
    }
}