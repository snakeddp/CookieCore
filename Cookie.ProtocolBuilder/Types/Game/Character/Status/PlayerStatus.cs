namespace Cookie.Protocol.Types.Game.Character.Status
{
    [NetworkType(415)]
    public class PlayerStatus
    {
        public sbyte StatusId { get; set; }
    }
}