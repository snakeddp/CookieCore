using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Interactive.Skill
{
    [NetworkMessage(6715)]
    public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
    {
        public int Id { get; set; }
    }
}