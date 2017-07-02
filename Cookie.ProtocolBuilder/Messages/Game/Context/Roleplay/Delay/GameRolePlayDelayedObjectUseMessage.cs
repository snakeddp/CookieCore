namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Delay
{
    [NetworkMessage(6425)]
    public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}