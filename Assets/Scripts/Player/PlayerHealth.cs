using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJame16
{
    public class PlayerHealth : Health
    {

        // Use this for initialization
        public override void Start()
        {
            health = 100;
            damage = 5;
        }

        public override void OnCollisionEnter(Collision col)
        {
            base.OnCollisionEnter(col);
        }
    }
}