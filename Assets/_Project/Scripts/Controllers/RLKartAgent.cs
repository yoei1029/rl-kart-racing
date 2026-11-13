using RLKart.Karts;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

namespace RLKart.Controllers
{
    // Observation, action and reward design are intentionally left undecided.
    public class RLKartAgent : Agent, IKartController
    {
        public KartInput GetInput(Kart kart)
        {
            throw new System.NotImplementedException();
        }

        public override void OnEpisodeBegin()
        {
        }

        public override void CollectObservations(VectorSensor sensor)
        {
        }

        public override void OnActionReceived(ActionBuffers actions)
        {
        }

        public override void Heuristic(in ActionBuffers actionsOut)
        {
        }
    }
}
