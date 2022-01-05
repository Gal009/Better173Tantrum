using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace Better173Tantrum
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 0);

        public static Plugin Singleton;
        public Handlers.Player2 player;

        public override void OnEnabled()
        {
            Singleton = this;
            player = new Handlers.Player2(this);

            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;
            Player.WalkingOnTantrum -= player.OnWalkingOnTantrum;

            player = null;
            Singleton = null;

            base.OnDisabled();
        }
    }
}