namespace Cookie.Protocol.Types.Game.Approach
{
    [NetworkType(429)]
    public class ServerSessionConstantLong : ServerSessionConstant
    {
        public double Value { get; set; }
    }
}