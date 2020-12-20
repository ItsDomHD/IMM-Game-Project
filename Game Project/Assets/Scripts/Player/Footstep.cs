using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Footstep : MonoBehaviour
    {
        private CharacterController charControl;
        private AudioSource audio;

        private void Start()
        {
            charControl = GetComponent<CharacterController>();
            audio = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (charControl.velocity.magnitude > 2F && audio.isPlaying == false)
            {
                audio.Play();
            }
        }
    }
}