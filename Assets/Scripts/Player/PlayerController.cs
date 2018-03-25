using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam16
{
    public class PlayerController : MonoBehaviour
    {
        public float inputH, inputV;
        public float movementSpeed = 5f;
        public bool isPunching = false;
        public bool isShooting = false;

        private Vector3 movement;
        private Animator anim;

        public BoolCallback onPunch;
        public BoolCallback onShoot;

        // Update is called once per frame
        void Update()
        {
            CharacterMovement();
        }

        void CharacterMovement()
        {
            // Movement
            CharacterController controller = GetComponent<CharacterController>();
            movement = new Vector3(inputH, 0, inputV);
            movement *= movementSpeed * Time.deltaTime;
            transform.Translate(movement);
        }

        public void Punch()
        {
            bool wasPunching = isPunching;
            // Perform punch logic


            // Invoke event
            if (onPunch != null && wasPunching != isPunching)
            {
                onPunch.Invoke(isPunching);
            }
        }

        public void TattooGun()
        {
            // Gun logic

            // Invoke event
            if (onShoot != null)
            {
                onShoot.Invoke(isShooting);
            }
        }

        public void Move(float horizontal, float vertical)
        {
            inputH = horizontal;
            inputV = vertical;
        }
    }
}
