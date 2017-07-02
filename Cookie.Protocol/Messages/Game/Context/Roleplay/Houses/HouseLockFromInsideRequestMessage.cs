using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(5885)]
    public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
    {
    }
}