namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5672)]
    public class LockableCodeResultMessage
    {
        public sbyte Result { get; set; }
    }
}