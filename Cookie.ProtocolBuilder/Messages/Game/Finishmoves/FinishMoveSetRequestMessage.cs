namespace Cookie.Protocol.Messages.Game.Finishmoves
{
    [NetworkMessage(6703)]
    public class FinishMoveSetRequestMessage
    {
        public uint FinishMoveId { get; set; }

        [RegularBool]
        public bool FinishMoveState { get; set; }
    }
}