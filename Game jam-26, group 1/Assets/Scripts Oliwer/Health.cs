using UnityEngine;

public class Health : MonoBehaviour
{
    public int _health = 100;
    public int _doDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _health -= _doDamage; 
            print("ouch!");
        }
    }
}
