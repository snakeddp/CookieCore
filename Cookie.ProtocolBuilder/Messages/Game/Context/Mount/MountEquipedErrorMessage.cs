namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5963)]
    public class MountEquipedErrorMessage
    {
        public sbyte ErrorType { get; set; }
    }
}