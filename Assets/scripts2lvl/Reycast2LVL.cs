using UnityEngine;

public class Reycast2LVL : MonoBehaviour
{
    private bool isBedroomk = false;
    private bool isSafek = false;
    private bool isMain = false;
    private bool isCoridk = false;
    private bool isEnter1 = false;  
    public GameObject maintext;
    private float timetowrite = 2f;
    private float timetostop = 0f; 
    void Start()
    {
        
    }

   
    void Update()
    {
        if (isEnter1)
        {
            maintext.SetActive(true);
            timetowrite -= Time.deltaTime;

            if (timetostop >= timetowrite)
            {
                maintext.SetActive(false);
                timetowrite = 0;
            }
        }
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
           if (hit.collider != null && hit.collider.tag == "mirror" && isEnter1)
            {
                Destroy(hit.collider.gameObject);
            }
           if (hit.collider != null && hit.collider.tag == "coridk")
            {
                isCoridk = true;
                Destroy(hit.collider.gameObject);   
            }
            if (hit.collider != null && hit.collider.tag == "safek")
            {
                isSafek = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "safe2" && isSafek)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "maink")
            {
                Destroy(hit.collider.gameObject);
                isMain = true;
            }
            if (hit.collider != null && hit.collider.tag == "lock" && isMain)
            {
                Destroy(hit.collider.gameObject);
            }

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mirror")
        {
            isEnter1 = true;
        }
    }
}
