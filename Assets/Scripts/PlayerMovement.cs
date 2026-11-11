/*using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float jumpForce = 10f;
    private Vector2 moveInput;
    private bool jumpInput;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        
    }

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
// Apply horizontal velocity from input
        rigidBody.linearVelocityX = moveInput.x * maxSpeed;
// Apply vertical velocity from jump
        if (jumpInput)
        {
            rigidBody.linearVelocityY = jumpForce;
        }
        jumpInput = false; // only jump once for each press of the jump-button
    }
    public void OnMove()
    {
        moveInput = ;
    }
}*/
