using UnityEngine;

public class move2 : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = (new Vector2(0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = (new Vector2(0, -speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = (new Vector2(speed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = (new Vector2(-speed, 0));
        }
    }
}
