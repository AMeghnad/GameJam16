using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam16
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(SpriteRenderer))]
    public class PlayerController : MonoBehaviour
    {
        public float inputH, inputV;
        public float movementSpeed = 5f;
        public bool isPunching = false;
        public bool isKicking = false;

        private Vector3 movement;
        private Animator anim;

        public BoolCallback onPunch;
        public BoolCallback onKick;
        
        // Update is called once per frame
        void Update()
        {
            CharacterMovement();
        }

        void CharacterMovement()
        {
            // Movement
            CharacterController controller = GetComponent<CharacterController>();
            movement = new Vector3(inputH, inputV);
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

        public void Kick()
        {
            //Kick logic

            // Invoke event
            if (onKick != null)
            {
                onKick.Invoke(isKicking);
            }
        }

        public void Move(float horizontal, float vertical)
        {
            inputH = horizontal;
            inputV = vertical;
        }
    }
}
