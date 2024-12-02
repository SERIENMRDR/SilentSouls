using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private float horizontal;
    [Range(1,100)]
    public float speed = 8f;
    [Range(1, 100)]
    public float jumpingPower = 16f;
    private bool isFacingright = true;

    private void Start()
    {
        Flip();
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontal*speed,rb.velocity.y);
        if (!isFacingright&& horizontal <0f){Flip();}
        if (isFacingright && horizontal > 0f){Flip();}
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpingPower);
        }
        if (context.performed && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y*0.5f);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if (!isFacingright)
        {
            Vector3 rotator = new Vector3(transform.rotation.x,180f,transform.rotation.y);
            transform.rotation = Quaternion.Euler(rotator);
            isFacingright = !isFacingright;
        }
        else if (isFacingright)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.y);
            transform.rotation = Quaternion.Euler(rotator);
            isFacingright = !isFacingright;
        }
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }
}