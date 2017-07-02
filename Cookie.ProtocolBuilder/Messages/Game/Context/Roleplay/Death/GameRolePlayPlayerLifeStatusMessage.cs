namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Death
{
    [NetworkMessage(5996)]
    public class GameRolePlayPlayerLifeStatusMessage
    {
        public sbyte State { get; set; }
        public uint PhenixMapId { get; set; }
    }
}