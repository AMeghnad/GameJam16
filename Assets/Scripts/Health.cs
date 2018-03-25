using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health, damage;
    // Use this for initialization
    public virtual void Start()
    {

    }

    public virtual void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }

        if (col.gameObject)
        {
            health -= damage;
        }
    }
}
