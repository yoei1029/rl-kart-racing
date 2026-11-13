using UnityEngine;

namespace RLKart.Track
{
    [RequireComponent(typeof(TrackDefinition))]
    public class TrackBuilder : MonoBehaviour
    {
        [SerializeField] private int checkpointCount = 32;

        public void Build()
        {
        }
    }
}
