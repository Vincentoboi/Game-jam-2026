using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RunAway : MonoBehaviour
{
    GameObject player;

    [SerializeField] LayerMask groundLayer, playerLayer, wallLayer, obstacleLayer;

    Vector3 destPoint;
    bool walkPointSet;
    [SerializeField] float range;

    [SerializeField] float sightRange;
    bool playerInSight;

    [SerializeField] private NavMeshAgent agent = null;
    [SerializeField] private Transform chaser = null;
    [SerializeField] private float displacementDist = 5f;


    public AudioRandomizer script; 
    


    void Start()
    {
        player = GameObject.Find("Player");
        if (agent == null)
        {
            if (TryGetComponent(out agent))
            {
                Debug.LogWarning(name + " needs a navmesh agent");
            }
        }
    }
    private void Update()
    {
        
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);

        if (!playerInSight)
        {
            Wandering();
        }
        if (playerInSight)
        {
            Run();
            Shout();
        }
    }

    private void Shout()
    {
        script.Sound();
    }

    private void Run()
    {
        if (chaser == null)
        {
            return;
        }
            Vector3 normDir = (chaser.position - transform.position).normalized;  
            //normDir = Quaternion.AngleAxis(45, Vector3.up) * normDir;
            MoveToPos(transform.position - (normDir * displacementDist));            
    }


    private void MoveToPos(Vector3 pos)
    {
        agent.SetDestination(pos);
        agent.isStopped = false;
    }

    private void Wandering()
    {
        if (!walkPointSet) SearchForDest();
        if (walkPointSet)
        {
            agent.SetDestination(destPoint);
        }
        if (Vector3.Distance(transform.position, destPoint) < 10)
        {
            walkPointSet = false;
        }
    }

    private void SearchForDest()
    {
        float z = Random.Range(-range, range);
        float x = Random.Range(-range, range);

        destPoint = new Vector3(transform.position.x + x, transform.position.z + z);

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer))
        {
            walkPointSet = true;
        }
    }
}