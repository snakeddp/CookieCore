namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6241)]
    public class DungeonPartyFinderRegisterSuccessMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] DungeonIds { get; set; }
    }
}