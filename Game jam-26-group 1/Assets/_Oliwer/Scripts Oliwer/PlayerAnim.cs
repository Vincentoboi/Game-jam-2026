using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public bool _Atacking;
    float _time;

    [Header("Needed Utils")]
    public Animator anim;

    [Header("Take From Scripts")]
    public PlayerMove _playerMoveScript;

    [Header("PlayerMove: Floats")]
    public float _moveSpeed;

    private PlayerAnim _playerAnim;

    private void Start()
    {
        _playerAnim = FindObjectOfType<PlayerAnim>();
    }

    void Update()
    {
        _moveSpeed = _playerMoveScript._moveSpeed;

        
        // Attack
        if (Input.GetButton("Fire1"))
        {
            anim.SetTrigger("Attack");
            _Atacking = true;
        }
        if (_Atacking == true)
        {
            _time += Time.deltaTime;
            if (_time >= 0.9f)
            {
                _time = 0;
                _Atacking = false;
            }
        }

        if (_moveSpeed >= 15)
        {
            anim.SetTrigger("PlayerRun");
        }

        if (_moveSpeed == 10)
        {
            anim.SetTrigger("PlayerWalk");
        }

        if (_moveSpeed == 0)
        {
            anim.SetTrigger("PlayerIdle");
        }
    }
}
