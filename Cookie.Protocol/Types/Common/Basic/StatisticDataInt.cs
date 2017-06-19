
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Common.Basic
{
    [NetworkType(485)]
    public class StatisticDataInt : StatisticData
    {
        public int Value { get; set; }
    }
}
