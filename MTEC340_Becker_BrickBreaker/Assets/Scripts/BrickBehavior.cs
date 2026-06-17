using UnityEditor;
using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
} 

