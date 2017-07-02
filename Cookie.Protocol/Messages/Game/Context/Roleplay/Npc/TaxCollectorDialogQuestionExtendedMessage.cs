using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5615)]
    public class TaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionBasicMessage
    {
        [CustomVar]
        public ushort MaxPods { get; set; }

        [CustomVar]
        public ushort Prospecting { get; set; }

        [CustomVar]
        public ushort Wisdom { get; set; }

        public sbyte TaxCollectorsCount { get; set; }
        public int TaxCollectorAttack { get; set; }

        [CustomVar]
        public long Kamas { get; set; }

        [CustomVar]
        public long Experience { get; set; }

        [CustomVar]
        public uint Pods { get; set; }

        [CustomVar]
        public long ItemsValue { get; set; }
    }
}