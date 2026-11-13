using System.Collections.Generic;
using RLKart.Race;
using UnityEngine;
using UnityEngine.Splines;

namespace RLKart.Track
{
    public class TrackDefinition : MonoBehaviour
    {
        [SerializeField] private string trackId;
        [SerializeField] private SplineContainer centerLine;
        [SerializeField] private float roadWidth = 12f;

        public string TrackId => trackId;
        public IReadOnlyList<Checkpoint> Checkpoints { get; private set; }
        public IReadOnlyList<Transform> StartGrid { get; private set; }

        public float GetProgress(Vector3 worldPosition)
        {
            throw new System.NotImplementedException();
        }

        public Vector3 GetWaypointAhead(Vector3 worldPosition, float lookAheadDistance)
        {
            throw new System.NotImplementedException();
        }
    }
}
