using RLKart.Karts;
using UnityEngine;

namespace RLKart.Track
{
    public class BoostPad : SurfaceZone
    {
        [SerializeField] private float boostMultiplier = 1.5f;
        [SerializeField] private float boostDuration = 1f;

        protected override void ApplyTo(Kart kart)
        {
        }
    }
}
