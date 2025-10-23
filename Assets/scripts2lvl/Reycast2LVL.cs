using UnityEngine;

public class Reycast2LVL : MonoBehaviour
{
    private bool isEnter2 = false;
    private bool isElectro = false;
    private bool isLivingk = false;
    private bool isBedroomk = false;
    private bool isKitchen = false;
    private bool isSafek = false;
    private bool isMain = false;
    private bool isCoridk = false;
    private bool isHammer = false;  
    private bool isEnter1 = false;

    public GameObject maintext;
    public GameObject maintext1;
    public GameObject placed;
    
    private float timetowrite = 2f;
    private float timetostop = 0f;
    private float timetowrite1 = 2f;
    private float timetostop1 = 0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (isEnter2)
        {
            maintext1.SetActive(true);
            timetowrite1 -= Time.deltaTime;

            if (timetostop1 >= timetowrite1)
            {
                maintext1.SetActive(false);
                timetowrite1 = 0;
            }
        }

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
            if (hit.collider != null && hit.collider.tag == "kitchenk")
            {
                Destroy(hit.collider.gameObject);
                isKitchen = true;
            }
            if (hit.collider != null && hit.collider.tag == "kitchen" && isKitchen)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "livingk")
            {
                isLivingk = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "livingr" && isLivingk)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "coridk")
            {
                isCoridk = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "coridor" && isCoridk)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "hammer")
            {
                isHammer = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "plank" && isHammer)
            {
                Destroy(hit.collider.gameObject);
                
            }
            if (hit.collider != null && hit.collider.tag == "electrok")
            {
                isElectro = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "electro" && isElectro)
            {
                Destroy(hit.collider.gameObject);
                
            }
            if (hit.collider != null && hit.collider.tag == "button")
            {
                //safek.SetActive(true);
                //placed.SetActive(false);
                //replaced.SetActive(true);
            }

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mirror")
        {
            isEnter1 = true;
        }
        if (collision.gameObject.tag == "panel")
        {
            isEnter2 = true;    
        }



    }
   
}
