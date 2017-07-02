namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6116)]
    public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        [CustomVar]
        public ushort WeaponGenericId { get; set; }
    }
}