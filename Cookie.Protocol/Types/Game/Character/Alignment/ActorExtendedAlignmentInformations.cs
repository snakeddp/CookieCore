using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character.Alignment
{
    [NetworkType(202)]
    public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
    {
        [CustomVar]
        public ushort Honor { get; set; }

        [CustomVar]
        public ushort HonorGradeFloor { get; set; }

        [CustomVar]
        public ushort HonorNextGradeFloor { get; set; }

        public sbyte Aggressable { get; set; }
    }
}