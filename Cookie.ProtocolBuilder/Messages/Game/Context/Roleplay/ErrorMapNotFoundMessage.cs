namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6197)]
    public class ErrorMapNotFoundMessage
    {
        public uint MapId { get; set; }
    }
}