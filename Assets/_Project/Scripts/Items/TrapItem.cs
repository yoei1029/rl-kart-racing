using RLKart.Karts;
using UnityEngine;

namespace RLKart.Items
{
    [CreateAssetMenu(menuName = "RLKart/Items/TrapItem")]
    public class TrapItem : ItemBase
    {
        public TrapObject trapPrefab;

        public override void Use(Kart user)
        {
        }
    }
}
