﻿namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5958)]
    public class PaddockRemoveItemRequestMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}