using UnityEngine;

public class Reycast3LVL : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null && hit.collider.tag == "door")
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "mirror")
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "code")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
