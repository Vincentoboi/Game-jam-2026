using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public static Vector3 spawnPosition;
    public static Quaternion spawnRotation;

    private void Awake()
    {
        spawnPosition = transform.position;
        spawnRotation = transform.rotation;
    }
}
