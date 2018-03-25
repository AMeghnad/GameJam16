using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam16
{
    
    [RequireComponent(typeof(Animator))]
    public class PlayerAnim : MonoBehaviour
    {
        public PlayerController player;
        private Animator anim;

        void OnEnable()
        {
            print("Enabled");
        }

        void OnDisable()
        {
            print("Disabled");
        }

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
           
            player.onPunch += OnPunch;
        }

        void OnPunch(bool onPunch)
        {
            if (onPunch)
            {
                // Punch animation
                print("Falcon Punch!");
            }

            else
            {
                // Idle animation
                print("Just chillin' :)");
            }
        }

        void OnKick(bool onKick)
        {
            if (onKick)
            {
                // Kick animation
                print("Falcon Kick!");
            }

            else
            {
                // Idle animation
                print("Just chillin' :)");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
