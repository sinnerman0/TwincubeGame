﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 170f;
    public float moveSpeed = 10f;
    public Joystick joystick;

    Rigidbody2D m_Rigidbody;
    Vector2 m_JumpDirection;
    float m_HorizontalInput;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        if (m_Rigidbody.gravityScale < 0)
        {
            jumpForce = -jumpForce;
        }
        m_JumpDirection = new Vector2(0f, jumpForce);
    }
    void FixedUpdate()
    {
        //Move();
    }

    void Move()
    {
        m_HorizontalInput = joystick.Horizontal;
        Vector2 movement = new Vector2(m_HorizontalInput * moveSpeed, 0);
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement * Time.deltaTime);
    }

    public void Jump()
    {
        m_Rigidbody.AddForce(m_JumpDirection);
    }
}
