using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private bool horizontolDirection;
    private Rigidbody2D _rigidbody2D;
    private bool _isStop;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    public void Stop()
    {
        _isStop = true;
        SetMove(false);
    }
    
    public void SetMove(bool canMove)
    {
        if (!canMove)
        {
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            if (!_isStop)
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
