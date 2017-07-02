namespace Cookie.Protocol.Types.Game.Finishmoves
{
    [NetworkType(506)]
    public class FinishMoveInformations
    {
        public uint FinishMoveId { get; set; }

        [RegularBool]
        public bool FinishMoveState { get; set; }
    }
}