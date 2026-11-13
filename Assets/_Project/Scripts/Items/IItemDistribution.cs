using RLKart.Karts;

namespace RLKart.Items
{
    public interface IItemDistribution
    {
        ItemBase Roll(Kart receiver);
    }
}
