using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [Header("Needed Utils")]
    public CharacterController controller;

    [Header("Gravity")]
    public float _gravity = -9f;
    public float _jumpHeight = 3f;
    Vector3 velocity;

    [Header("GroundChecks")]
    public Transform groundCheck;
    public float _groundDistance = 1f;
    public LayerMask groundMask;
    bool _isGrounded;

    [Header("Script Virables")]
    public float _idleSpeed = 0f;
    public float _walkSpeed = 10f;
    public float _runSpeed = 15f;
    public float _moveSpeed;

    void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, _groundDistance, groundMask);
        if (_isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //minus två så den inte regristrerar innan vi nått marken
        }
        float x = Input.GetAxis("Horizontal"); //Gå med WASD
        float z = Input.GetAxis("Vertical"); // -.- 

        Vector3 move = transform.right * x + transform.forward * z; //Rör sig i den riktningen som player också tittar i
        controller.Move(move * _moveSpeed * Time.deltaTime); //Ref till vår charactercontroller som driver vår player + låter oss röra på oss

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }

        velocity.y += _gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _walkSpeed = _runSpeed;
        }
        else
        {
            _walkSpeed = 10f;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _moveSpeed = _walkSpeed;
        }
        else
        {
            _moveSpeed = _idleSpeed;
        }
    }
}
