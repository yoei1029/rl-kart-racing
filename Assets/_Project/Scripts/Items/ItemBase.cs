using RLKart.Karts;
using UnityEngine;

namespace RLKart.Items
{
    public abstract class ItemBase : ScriptableObject
    {
        public string displayName;
        public Sprite icon;

        public abstract void Use(Kart user);
    }
}
