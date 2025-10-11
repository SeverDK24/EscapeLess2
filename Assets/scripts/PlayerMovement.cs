using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 3;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2 (0,speed)); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed,0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
        }
    }
}
