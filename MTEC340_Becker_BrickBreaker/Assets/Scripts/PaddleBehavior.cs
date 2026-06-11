using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;
    public KeyCode RightDirection = KeyCode.RightArrow;
    public KeyCode LeftDirection = KeyCode.LeftArrow;
    public float minX = -5.25f;
    public float maxX = 5.25f;
    
    void Update()
    { 
        // Create a movement variable
        Vector3 movement = Vector3.zero;
        
        // Update variable based on player's input 
        if (Input.GetKey(RightDirection))
        {
            movement.x += Speed; 
        }
        
        if (Input.GetKey(LeftDirection))
        {
            movement.x -= Speed;
        }
            
        // consider frame rate to make game platform agnostic 
        movement *= Time.deltaTime;
        transform.position += movement;

        float horizontalInput = Input.GetAxis("Horizontal");
        float targetX = transform.position.x + (horizontalInput * Speed * Time.deltaTime);
        float clampedX = Mathf.Clamp(targetX, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}