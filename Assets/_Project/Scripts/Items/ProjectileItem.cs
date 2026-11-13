using RLKart.Karts;
using UnityEngine;

namespace RLKart.Items
{
    [CreateAssetMenu(menuName = "RLKart/Items/ProjectileItem")]
    public class ProjectileItem : ItemBase
    {
        public Projectile projectilePrefab;

        public override void Use(Kart user)
        {
        }
    }
}
