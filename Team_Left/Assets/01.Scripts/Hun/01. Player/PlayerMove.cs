using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _PlayerInput;
    private Rigidbody _Rigidbody;

    public float MoveSpeed;
    public float JumpPower;
    private void Awake()
    {
        _PlayerInput = GetComponent<PlayerInput>();
        _Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement(_PlayerInput.Horizontal, _PlayerInput.Vertical);
        if (_PlayerInput.Key_Space) {Jump();}
    }

    private void Movement(float Horizontal, float Vertical)
    {
        _Rigidbody.velocity = new Vector3(Horizontal, 0, Vertical) * MoveSpeed * Time.deltaTime;
        //transform.position += new Vector3(Horizontal, 0, Vertical) * MoveSpeed * Time.deltaTime;
    }

    private void Jump()
    {
        _Rigidbody.AddForce(0, JumpPower, 0);
    }
}
