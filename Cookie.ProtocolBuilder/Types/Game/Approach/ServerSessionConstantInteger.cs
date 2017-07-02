namespace Cookie.Protocol.Types.Game.Approach
{
    [NetworkType(433)]
    public class ServerSessionConstantInteger : ServerSessionConstant
    {
        public int Value { get; set; }
    }
}