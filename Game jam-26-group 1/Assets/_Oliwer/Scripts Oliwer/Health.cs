using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Shared Variables")]
    public float _health = 100f;
    public bool _isDead = false;

    [Header("Script Variables")]
    public float _doDamage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _health -= _doDamage;
            print("ouch!");
        }
    }
    private void Update()
    {
        if (_health == 0)
        {
            Destroy(transform.parent);
        }
    }
}
