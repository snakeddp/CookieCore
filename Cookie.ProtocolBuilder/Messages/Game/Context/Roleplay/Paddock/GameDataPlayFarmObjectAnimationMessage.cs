namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6026)]
    public class GameDataPlayFarmObjectAnimationMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] CellId { get; set; }
    }
}