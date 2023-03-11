using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private bool horizontolDirection;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RotationTo(true);
        }
    }

    public void SetMove(bool canMove)
    {
        if (!canMove)
        {
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            if (horizontolDirection)
            {
                _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation 
                                           | RigidbodyConstraints2D.FreezePositionY;
            }
            else
            {
                _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation 
                                           | RigidbodyConstraints2D.FreezePositionX;
            }
        }
    }
    public void RotationTo(bool right)
    {
        if (horizontolDirection) horizontolDirection = false;
        else horizontolDirection = true;
        
        if (right)
        {
            _rigidbody2D.rotation -= 90;
        }
        else
        {
            _rigidbody2D.rotation += 90;
        }
    }
}
