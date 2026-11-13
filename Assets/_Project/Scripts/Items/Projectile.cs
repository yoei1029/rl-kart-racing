using UnityEngine;

namespace RLKart.Items
{
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed = 40f;
        [SerializeField] private int maxBounces = 3;

        private void OnCollisionEnter(Collision collision)
        {
        }
    }
}
