using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam16
{
    [RequireComponent(typeof(PlayerController))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerController player;

        // Use this for initialization
        void Start()
        {
            player = GetComponent<PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            GetInput();
        }

        void GetInput()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            player.Move(inputH, inputV);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Punch();
            }
        }

        void Punch()
        {

        }
    }
}