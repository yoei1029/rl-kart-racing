using RLKart.Controllers;

namespace RLKart.Core
{
    public enum RaceModeType
    {
        Versus,
        Spectator,
        TimeTrial
    }

    [System.Serializable]
    public class RaceSettings
    {
        public RaceModeType mode = RaceModeType.Versus;
        public string trackId;
        public int laps = 3;
        public bool itemsEnabled = true;
        public AIDifficulty aiDifficulty = AIDifficulty.Normal;
    }
}
