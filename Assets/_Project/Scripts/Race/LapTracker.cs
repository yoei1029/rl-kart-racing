using System.Collections.Generic;
using UnityEngine;

namespace RLKart.Race
{
    public class LapTracker : MonoBehaviour
    {
        public int CurrentLap { get; private set; }
        public int NextCheckpointIndex { get; private set; }
        public float RaceProgress { get; private set; }
        public float BestLapTime { get; private set; }
        public IReadOnlyList<float> LapTimes { get; private set; }
        public bool HasFinished { get; private set; }

        public void OnCheckpointPassed(Checkpoint checkpoint)
        {
        }
    }
}
