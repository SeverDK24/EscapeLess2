using UnityEngine;

public class Reycast2LVL : MonoBehaviour
{
    private bool isBedroomk = false;
    void Start()
    {
        
    }

   
    void Update()
    {
       Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null && hit.collider.tag == "door2")
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "bedroomk")
            {
                isBedroomk = true;  
                Destroy(hit.collider.gameObject);

            }
            if (hit.collider != null && hit.collider.tag == "Bedroom" && isBedroomk)
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
