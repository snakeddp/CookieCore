
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Character.Restriction
{
    [NetworkType(204)]
    public class ActorRestrictionsInformations
    {
        public bool CantBeAggressed { get; set; }
        public bool CantBeChallenged { get; set; }
        public bool CantTrade { get; set; }
        public bool CantBeAttackedByMutant { get; set; }
        public bool CantRun { get; set; }
        public bool ForceSlowWalk { get; set; }
        public bool CantMinimize { get; set; }
        public bool CantMove { get; set; }
        public bool CantAggress { get; set; }
        public bool CantChallenge { get; set; }
        public bool CantExchange { get; set; }
        public bool CantAttack { get; set; }
        public bool CantChat { get; set; }
        public bool CantBeMerchant { get; set; }
        public bool CantUseObject { get; set; }
        public bool CantUseTaxCollector { get; set; }
        public bool CantUseInteractive { get; set; }
        public bool CantSpeakToNPC { get; set; }
        public bool CantChangeZone { get; set; }
        public bool CantAttackMonster { get; set; }
        public bool CantWalk8Directions { get; set; }
    }
}
