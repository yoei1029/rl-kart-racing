using UnityEngine;

namespace RLKart.Karts
{
    [RequireComponent(typeof(Rigidbody))]
    public class KartMotor : MonoBehaviour
    {
        public float Speed { get; private set; }
        public float SpeedMultiplier { get; set; } = 1f;

        public void Initialize(KartStats stats)
        {
        }

        public void Apply(KartInput input, float deltaTime)
        {
        }

        private void OnCollisionEnter(Collision collision)
        {
        }
    }
}
