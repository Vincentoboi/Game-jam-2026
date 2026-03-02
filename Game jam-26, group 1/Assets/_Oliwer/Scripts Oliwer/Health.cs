using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Shared Varible")]
    public float _health = 100;

    [Header("Script Varible")]
    public float _doDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _health -= _doDamage;
            print("ouch!");
        }
    }
}

//This hurts the object for the set damage when touching the Player.
