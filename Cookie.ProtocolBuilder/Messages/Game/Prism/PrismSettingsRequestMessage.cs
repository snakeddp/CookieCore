﻿namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6437)]
    public class PrismSettingsRequestMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        public sbyte StartDefenseTime { get; set; }
    }
}