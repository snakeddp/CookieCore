﻿namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6461)]
    public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
    {
        [RegularBool]
        public bool Preview { get; set; }
    }
}