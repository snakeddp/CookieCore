namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Delay
{
    [NetworkMessage(6153)]
    public class GameRolePlayDelayedActionMessage
    {
        public double DelayedCharacterId { get; set; }
        public sbyte DelayTypeId { get; set; }
        public double DelayEndTime { get; set; }
    }
}