namespace Cookie.Protocol.Types.Game.Character.Status
{
    [NetworkType(414)]
    public class PlayerStatusExtended : PlayerStatus
    {
        public string Message { get; set; }
    }
}