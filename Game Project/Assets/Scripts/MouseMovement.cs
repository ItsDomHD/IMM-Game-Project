using UnityEngine;

namespace DefaultNamespace
{
    public class MouseMovement : MonoBehaviour
    {
        public float mouseSensitivity = 100F;

        public Transform playerBody;

        private float xRotation;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            var mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            var mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90F, 90F);

            transform.localRotation = Quaternion.Euler(xRotation, 0F, 0F);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}