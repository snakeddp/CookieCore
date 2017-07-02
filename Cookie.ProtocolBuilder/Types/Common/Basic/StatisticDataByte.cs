namespace Cookie.Protocol.Types.Common.Basic
{
    [NetworkType(486)]
    public class StatisticDataByte : StatisticData
    {
        public byte Value { get; set; }
    }
}