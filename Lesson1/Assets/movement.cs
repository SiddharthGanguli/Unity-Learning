using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f; // units per second
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D attached to this object
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Read input from keyboard (WASD or arrow keys)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector2 movement = new Vector2(moveX, moveY);

        // Move the ball by setting Rigidbody2D velocity
        rb.linearVelocity = movement * 3*speed;
    }
}
