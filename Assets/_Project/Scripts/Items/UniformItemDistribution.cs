using System.Collections.Generic;
using RLKart.Karts;

namespace RLKart.Items
{
    public class UniformItemDistribution : IItemDistribution
    {
        private readonly IReadOnlyList<ItemBase> items;

        public UniformItemDistribution(IReadOnlyList<ItemBase> items)
        {
            this.items = items;
        }

        public ItemBase Roll(Kart receiver)
        {
            throw new System.NotImplementedException();
        }
    }
}
