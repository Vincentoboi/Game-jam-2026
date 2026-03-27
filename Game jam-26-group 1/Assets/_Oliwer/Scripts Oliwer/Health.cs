using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Shared Variables")]
    public float _health = 100f;
    public bool _isDead = false;

    [Header("Script Variables")]
    public float _doDamage = 10f;
    public bool instanciate = false;

    [Header("Particle Effect")]
    public ParticleSystem _deathParticles;
    public ParticleSystem _damageParticles;

    [Header("")]
    private PlayerAnim _playerAnim;

    private void Start()
    {
        _playerAnim = FindObjectOfType<PlayerAnim>();
    }

    private void Update()
    {

        if (instanciate)
        {
            Instantiate(_damageParticles, transform.position, Quaternion.identity);
            
        }
        else return;


        if (_health <= 0)
        {
            Instantiate(_deathParticles, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knife") && _playerAnim._Atacking == true)
        {
            _health -= _doDamage;
            instanciate = true;
            print("ouch!");
        }
        else
        {
            instanciate = false;
        }
    }

}
