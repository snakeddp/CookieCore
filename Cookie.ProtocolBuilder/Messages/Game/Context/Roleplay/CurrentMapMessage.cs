namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(220)]
    public class CurrentMapMessage
    {
        public uint MapId { get; set; }
        public string MapKey { get; set; }
    }
}