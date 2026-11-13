using RLKart.Karts;
using UnityEngine;

namespace RLKart.Track
{
    [RequireComponent(typeof(Collider))]
    public abstract class SurfaceZone : MonoBehaviour
    {
        protected abstract void ApplyTo(Kart kart);

        private void OnTriggerStay(Collider other)
        {
        }
    }
}
