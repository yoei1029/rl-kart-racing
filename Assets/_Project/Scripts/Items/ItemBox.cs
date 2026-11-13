using UnityEngine;

namespace RLKart.Items
{
    [RequireComponent(typeof(Collider))]
    public class ItemBox : MonoBehaviour
    {
        [SerializeField] private float respawnSeconds = 3f;

        private void OnTriggerEnter(Collider other)
        {
        }
    }
}
