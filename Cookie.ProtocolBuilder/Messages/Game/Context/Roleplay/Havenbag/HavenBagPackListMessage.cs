﻿namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6620)]
    public class HavenBagPackListMessage
    {
        [LengthType(typeof(short), true)]
        public byte[] PackIds { get; set; }
    }
}