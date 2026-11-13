using UnityEngine;

namespace RLKart.Karts
{
    [CreateAssetMenu(menuName = "RLKart/Kart Stats")]
    public class KartStats : ScriptableObject
    {
        public float maxSpeed;
        public float acceleration;
        public float braking;
        public float steering;
        public float grip;
    }
}
