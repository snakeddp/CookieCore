using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6697)]
    public class MountHarnessColorsUpdateRequestMessage
    {
        [RegularBool]
        public bool UseHarnessColors { get; set; }
    }
}