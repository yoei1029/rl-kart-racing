using System.Collections.Generic;
using RLKart.Core;

namespace RLKart.Race
{
    public abstract class RaceMode
    {
        public abstract IReadOnlyList<KartSlot> CreateSlots(RaceSettings settings);

        public abstract bool IsRaceOver(RaceManager race);
    }
}
