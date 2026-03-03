using UnityEngine;
using UnityEngine.AI;


public class Chaser : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent = null;
    [SerializeField] private Transform target = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (agent == null)
        {
            if(TryGetComponent(out agent))
            {
                Debug.LogWarning(name + " needs a navmesh agent");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            MoveToTarget();
        }
    }

    private void MoveToTarget()
    {
        agent.SetDestination(target.position);
        agent.isStopped = false;
    }

}
