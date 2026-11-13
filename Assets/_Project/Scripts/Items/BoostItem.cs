using RLKart.Karts;
using UnityEngine;

namespace RLKart.Items
{
    [CreateAssetMenu(menuName = "RLKart/Items/BoostItem")]
    public class BoostItem : ItemBase
    {
        public float multiplier = 1.5f;
        public float duration = 1.5f;

        public override void Use(Kart user)
        {
        }
    }
}
