using RLKart.Karts;

namespace RLKart.Controllers
{
    public interface IKartController
    {
        KartInput GetInput(Kart kart);
    }
}
