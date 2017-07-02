namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6644)]
    public class HavenBagDailyLoteryMessage
    {
        public sbyte ReturnType { get; set; }
        public string TokenId { get; set; }
    }
}