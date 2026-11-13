using RLKart.Karts;
using UnityEngine;

namespace RLKart.Track
{
    public class SlowZone : SurfaceZone
    {
        [SerializeField] private float speedMultiplier = 0.5f;

        protected override void ApplyTo(Kart kart)
        {
        }
    }
}
