using RLKart.Items;

namespace RLKart.Karts
{
    public class ItemSlot
    {
        public ItemBase Current { get; private set; }

        public bool TryStore(ItemBase item)
        {
            throw new System.NotImplementedException();
        }

        public void Use(Kart owner)
        {
        }
    }
}
