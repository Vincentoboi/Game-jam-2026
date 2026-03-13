using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [Header("Needed Utils")]
    public Animator anim;

    [Header("Take From Scripts")]
    public PlayerMove _playerMoveScript;

    [Header("PlayerMove: Floats")]
    public float _moveSpeed;

    void Update()
    {
        _moveSpeed = _playerMoveScript._moveSpeed;


        // Attack
        if (Input.GetButton("Fire1"))
        {
            anim.SetTrigger("Attack");
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
