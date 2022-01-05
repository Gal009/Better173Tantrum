using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Better173Tantrum
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;

        [Description("The message that appears when someone walks on 173's tantrum")]
        public string WalkingOnTantrumMessage { get; set; } = "You are getting <color=black>corroded</color>.";

        [Description("How much time 173 stays with the SCP-207 effect after placing the tantrum")]
        public float PeanutPlacingTantrumCokeTime { get; set; } = 10;

        [Description("how much time a person is poisoned after walking in the SCP-173 tantrum")]
        public float PeanutPoisoningWalkingOnTantrumTime { get; set; } = 6;

        [Description("How much time a person is bleeding after walking in the SCP-173 tantrum")]
        public float PeanutBleedingWalkingOnTantrumTime { get; set; } = 5;

        [Description("The message that appears when SCP-173 places the tantrum")]
        public string PlacingTantrumMessage { get; set; } = "You feel faster...";

        [Description("The intensity of the 173 speed boost when he places the tantrum")]
        public byte Intensity173Speedboost { get; set; } = 20;
    }
}