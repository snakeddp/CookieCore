namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6041)]
    public class PrismUseRequestMessage
    {
        public sbyte ModuleToUse { get; set; }
    }
}