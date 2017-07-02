namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6249)]
    public class DungeonPartyFinderRegisterRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] DungeonIds { get; set; }
    }
}