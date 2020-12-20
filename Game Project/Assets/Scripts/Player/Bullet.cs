using System;
using System.Security.Cryptography;
using UnityEngine;

namespace DefaultNamespace
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 8f;
        public float timeToLive = 2f;

        private float lifeTimer;

        private void Start()
        {
            lifeTimer = timeToLive;
        }

        private void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            lifeTimer -= Time.deltaTime;
            if (lifeTimer <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}