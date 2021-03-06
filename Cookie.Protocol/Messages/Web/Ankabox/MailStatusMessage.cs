﻿using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Web.Ankabox
{
    [NetworkMessage(6275)]
    public class MailStatusMessage
    {
        [CustomVar]
        public ushort Unread { get; set; }

        [CustomVar]
        public ushort Total { get; set; }
    }
}