using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.Events.EventArgs;

namespace Better173Tantrum.Handlers
{
    public class Player2
    {
        private readonly Plugin plugin;
        public Player2(Plugin plugin) => this.plugin = plugin;

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(plugin.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, plugin.Config.PeanutPoisoningWalkingOnTantrumTime);
                ev.Player.EnableEffect(EffectType.Bleeding, plugin.Config.PeanutBleedingWalkingOnTantrumTime);
            }
        }
        
        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.PlacingTantrumMessage, 5);
            ev.Player.EnableEffect(EffectType.MovementBoost, plugin.Config.PeanutPlacingTantrumCokeTime);
            ev.Player.ChangeEffectIntensity<MovementBoost>(plugin.Config.Intensity173Speedboost);
        }
    }
}
