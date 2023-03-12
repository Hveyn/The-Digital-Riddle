using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float moveSpeed;

    private Rigidbody2D _rb;
    private Vector2 _moveDirection;
    private Vector2 _mousePosition;
    private Vector3 _newPosition;
    private bool _upInput;
    private bool _isInput = true;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        InputProcess();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void InputProcess()
    {
        float horizontalMove = 0;
        float verticalMove = 0;
        
        if (_isInput)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            verticalMove = Input.GetAxisRaw("Vertical");
        }

        _moveDirection = new Vector2(x: horizontalMove, verticalMove).normalized;
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    private void Move()
    {
        _rb.velocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }

    public void UpInput()
    {
        _isInput = true;
    }
    
    public void DownInput()
    {
        _isInput = false;
    }
    
}
