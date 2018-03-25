using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 playerDirection;
    NavMeshAgent nav; //reference to an object with NavMeshAgent agent, set it in inspector, for example
    private Rigidbody rigi;
    public float movementSpeed = 2;

    public float maxSpeed = 10f;
    public float maxDistance = 5f;
   

    public Vector3 velocity;
    private Vector3 force;

    public void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        rigi = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    public void Update()
    {
        //grab diference in x positions between player and enemy
        //if diference is posetive then add force right if negative add force left
        //if enemy reaches stopping distance 
        //FreezeZ();
        if (player != null)
        {
            Vector3 playerDirection = player.position - transform.position;
            if (playerDirection.x > 2 || playerDirection.x < -2 )
            {

                nav.SetDestination(new Vector3(player.position.x, transform.position.y, transform.position.z));

                Debug.Log(player != null);
               
            }
             if (playerDirection.x >= 2 || playerDirection.x <= -2)
            {
                nav.SetDestination(player.position);
            }
            
        }

    }
    

    //void UnFreezez()
    //{
       // rigi.constraints = RigidbodyConstraints.None;
       // rigi.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    //}
    //void FreezeZ()
    //{
       // rigi.constraints = RigidbodyConstraints.FreezePositionZ;
    //}

}