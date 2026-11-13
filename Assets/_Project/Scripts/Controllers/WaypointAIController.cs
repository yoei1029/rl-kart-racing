using RLKart.Karts;
using RLKart.Track;
using UnityEngine;

namespace RLKart.Controllers
{
    public class WaypointAIController : MonoBehaviour, IKartController
    {
        [SerializeField] private AIDifficulty difficulty = AIDifficulty.Normal;
        [SerializeField] private TrackDefinition track;

        public KartInput GetInput(Kart kart)
        {
            throw new System.NotImplementedException();
        }
    }
}
