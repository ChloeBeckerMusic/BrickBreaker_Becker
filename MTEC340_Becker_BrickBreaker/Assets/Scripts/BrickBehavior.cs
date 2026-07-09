using UnityEditor;
using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            GameBehavior.Instance.Score += 100;
        }
    }
} 

