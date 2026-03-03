using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;


public class RunAway : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent = null;
    [SerializeField] private Transform chaser = null;
    [SerializeField] private float displacementDist = 5f;

    void Start()
    {
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
        if (chaser == null)
        {
            return;
        }
        Vector3 normDir = (chaser.position - transform.position).normalized;

        normDir = Quaternion.AngleAxis(45, Vector3.up) * normDir;

        MoveToPos(transform.position - (normDir * displacementDist));
    }

    private void MoveToPos(Vector3 pos)
    {
        agent.SetDestination(pos);
        agent.isStopped = false;
    }
}