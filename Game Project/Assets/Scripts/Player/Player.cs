using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public Camera playerCamera;
        public GameObject bulletEmitter;
        public GameObject bulletPrefab;
        public AudioSource gunShot;

        private void Start()
        {
            gunShot = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gunShot.Play();

                GameObject TempBulletHandler;
                TempBulletHandler = Instantiate(bulletPrefab, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
                // GameObject bulletObject = Instantiate(this.bulletPrefab);
                // bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
                // bulletObject.transform.forward = playerCamera.transform.forward;
                // bulletObject.transform.rotation = playerCamera.transform.rotation;
            }
        }
    }
}