using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
class EnemyMovement : MonoBehaviour
{
    public Transform player;
    
    NavMeshAgent agent; //reference to an object with NavMeshAgent agent, set it in inspector, for example

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void FixedUpdate()
    {
       
    }
}