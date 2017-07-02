namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Delay
{
    [NetworkMessage(6150)]
    public class GameRolePlayDelayedActionFinishedMessage
    {
        public double DelayedCharacterId { get; set; }
        public sbyte DelayTypeId { get; set; }
    }
}