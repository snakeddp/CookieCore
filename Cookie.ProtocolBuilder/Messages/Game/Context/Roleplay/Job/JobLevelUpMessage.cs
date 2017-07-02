using Cookie.Protocol.Types.Game.Context.Roleplay.Job;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5656)]
    public class JobLevelUpMessage
    {
        public sbyte NewLevel { get; set; }
        public JobDescription JobsDescription { get; set; }
    }
}