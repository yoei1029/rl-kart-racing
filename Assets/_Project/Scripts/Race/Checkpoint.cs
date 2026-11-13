using UnityEngine;

namespace RLKart.Race
{
    [RequireComponent(typeof(Collider))]
    public class Checkpoint : MonoBehaviour
    {
        [SerializeField] private int index;

        public int Index => index;

        private void OnTriggerEnter(Collider other)
        {
        }
    }
}
