﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    public float speed;

    private float _fallVelocity = 0;
    private CharacterController _characterController;
    private Vector3 _moveVector;


    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MovementUpdate();
    }

    private void MovementUpdate()
    {

        _moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.forward;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _moveVector -= transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector += transform.right;
        }
    }
    void FixedUpdate()
    {
        _characterController.Move(_moveVector * speed * Time.fixedDeltaTime);

        _fallVelocity += gravity * Time.deltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }

}
