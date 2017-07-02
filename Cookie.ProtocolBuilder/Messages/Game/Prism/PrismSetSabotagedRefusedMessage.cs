﻿namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6466)]
    public class PrismSetSabotagedRefusedMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        public byte Reason { get; set; }
    }
}