using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Common.Basic
{
    [NetworkType(487)]
    public class StatisticDataString : StatisticData
    {
        public string Value { get; set; }
    }
}