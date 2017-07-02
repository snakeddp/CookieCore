using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Paddock;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(5824)]
    public class PaddockPropertiesMessage
    {
        public PaddockInstancesInformations Properties { get; set; }
    }
}