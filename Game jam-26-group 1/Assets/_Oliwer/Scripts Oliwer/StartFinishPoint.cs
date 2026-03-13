using UnityEngine;

public class StartFinishPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // Go to next level
            SceneController._instance.NextLevel();
        }
    }
}
