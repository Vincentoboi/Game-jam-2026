using UnityEngine;

public class EffectObject : MonoBehaviour
{
    [Header("Time")]
    public float time;
    
    void Start()
    {
        Destroy(gameObject, time);
    }
}
