namespace Cookie.Protocol.Types.Common.Basic
{
    [NetworkType(482)]
    public class StatisticDataBoolean : StatisticData
    {
        [RegularBool]
        public bool Value { get; set; }
    }
}