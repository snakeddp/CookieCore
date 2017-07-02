namespace Cookie.Protocol.Messages.Game.Approach
{
    [NetworkMessage(6340)]
    public class ServerSettingsMessage
    {
        public string Lang { get; set; }
        public sbyte Community { get; set; }
        public byte GameType { get; set; }

        [CustomVar]
        public ushort ArenaLeaveBanTime { get; set; }
    }
}