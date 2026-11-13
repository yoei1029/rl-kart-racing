using RLKart.Karts;
using UnityEngine;

namespace RLKart.Items
{
    [CreateAssetMenu(menuName = "RLKart/Items/ShieldItem")]
    public class ShieldItem : ItemBase
    {
        public float duration = 5f;

        public override void Use(Kart user)
        {
        }
    }
}
