using UnityEngine;

public class PaddleHandlerBehaviour : MonoBehaviour
{
    public float paddleSpeed = 5f;
    private Rigidbody paddleRigidbody;

    private void Start()
    {
        paddleRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get input for paddle movement
        float horizontalInput = Input.GetAxis("Horizontal");
        
        // Move the paddle
        Vector3 paddleVelocity = new Vector3(horizontalInput * paddleSpeed, 0f, 0f);
        paddleRigidbody.velocity = paddleVelocity;
    }
}