using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Ground"))
            isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.CompareTag("Ground"))
            isGrounded = false;
    }
}
