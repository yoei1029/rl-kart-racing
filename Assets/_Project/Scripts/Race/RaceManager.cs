using System;
using System.Collections.Generic;
using RLKart.Core;
using RLKart.Karts;
using UnityEngine;

namespace RLKart.Race
{
    public class RaceManager : MonoBehaviour
    {
        public event Action<IReadOnlyList<Kart>> RaceFinished;

        public IReadOnlyList<Kart> Karts { get; private set; }

        public void SetupRace(RaceSettings settings, RaceMode mode)
        {
        }

        public void BeginRace()
        {
        }

        public IReadOnlyList<Kart> GetRanking()
        {
            throw new NotImplementedException();
        }
    }
}
