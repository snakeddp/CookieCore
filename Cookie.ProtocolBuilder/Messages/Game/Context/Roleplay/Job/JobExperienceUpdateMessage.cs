using Cookie.Protocol.Types.Game.Context.Roleplay.Job;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Job
{
    [NetworkMessage(5654)]
    public class JobExperienceUpdateMessage
    {
        public JobExperience ExperiencesUpdate { get; set; }
    }
}