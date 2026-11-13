using RLKart.Karts;
using UnityEngine;

namespace RLKart.CameraSystem
{
    public class KartFollowCamera : MonoBehaviour
    {
        [SerializeField] private Kart target;

        public void SetTarget(Kart kart)
        {
        }

        private void LateUpdate()
        {
        }
    }
}
