using RLKart.Controllers;
using RLKart.Race;
using UnityEngine;

namespace RLKart.Karts
{
    [RequireComponent(typeof(KartMotor), typeof(LapTracker), typeof(RespawnHandler))]
    public class Kart : MonoBehaviour
    {
        [SerializeField] private KartStats stats;

        public IKartController Controller { get; private set; }
        public KartMotor Motor { get; private set; }
        public LapTracker Lap { get; private set; }
        public ItemSlot Items { get; private set; }
        public bool HasShield { get; private set; }

        public void AssignController(IKartController controller)
        {
        }

        public void ApplyBoost(float multiplier, float duration)
        {
        }

        public void ApplyStun(float duration)
        {
        }

        public void ActivateShield(float duration)
        {
        }

        private void FixedUpdate()
        {
        }
    }
}
