namespace Cookie.Protocol.Types.Common.Basic
{
    [NetworkType(488)]
    public class StatisticDataShort : StatisticData
    {
        public short Value { get; set; }
    }
}