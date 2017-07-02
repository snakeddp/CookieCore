namespace Cookie.Protocol.Messages.Game.Character.Replay
{
    [NetworkMessage(167)]
    public class CharacterReplayRequestMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }
    }
}