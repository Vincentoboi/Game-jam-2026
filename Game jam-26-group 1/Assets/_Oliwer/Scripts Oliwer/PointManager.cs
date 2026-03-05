using UnityEngine;

public class PointManager : MonoBehaviour
{
    [Header("Points")]
    public int _CurrentPoints = 0;
    public int _rewardingPoints = 10;

    void Update()
    {
        Health[] allHealthScripts = FindObjectsOfType<Health>();

        foreach (Health h in allHealthScripts)
        {
            if (h._health <= 0 && !h._isDead)
            {
                _CurrentPoints += _rewardingPoints;
                h._isDead = true;

                Debug.Log("Quest Completed for: " + h.name);
            }
        }
    }
}
