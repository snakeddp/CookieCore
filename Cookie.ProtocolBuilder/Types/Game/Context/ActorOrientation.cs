namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(353)]
    public class ActorOrientation
    {
        public double Id { get; set; }
        public sbyte Direction { get; set; }
    }
}