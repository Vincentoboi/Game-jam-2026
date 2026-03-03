using UnityEngine;
using UnityEngine.AI;


public class RunAway : MonoBehaviour
{
    [SerializeField] private Transform chaser = null;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector3 direction = (chaser.position - transform.position).normalized; //direction is turned into one value
        float mag = direction.magnitude; //will become one
        print(mag);

        Gizmos.DrawLine(transform.position, transform.position - direction);
    }
}