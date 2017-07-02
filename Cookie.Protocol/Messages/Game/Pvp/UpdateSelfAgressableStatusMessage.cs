using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(6456)]
    public class UpdateSelfAgressableStatusMessage
    {
        public sbyte Status { get; set; }
        public uint ProbationTime { get; set; }
    }
}