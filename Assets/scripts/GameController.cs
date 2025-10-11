using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private bool isOpen = false;
    public GameObject textInteract;
    private float openTime = 3f;
    public float timer;

   
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
                textInteract.SetActive(false);
            }
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door")
        {
            
            textInteract.SetActive(true);
            
           


        }
       
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door")
        {
           
            textInteract.SetActive(false);
           
        }
    }
}
