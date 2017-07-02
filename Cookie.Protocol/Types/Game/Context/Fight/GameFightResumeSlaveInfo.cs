using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(364)]
    public class GameFightResumeSlaveInfo
    {
        public double SlaveId { get; set; }
        public sbyte SummonCount { get; set; }
        public sbyte BombCount { get; set; }
    }
}