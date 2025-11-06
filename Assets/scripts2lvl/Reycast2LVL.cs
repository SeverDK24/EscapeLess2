using UnityEngine;
using UnityEngine.UI;

public class Reycast2LVL : MonoBehaviour
{
    private bool isLock = false;
    private bool isCabel = false;   
    private bool isPlank = false;
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
    private bool isPilers = false;
    private bool isEnter3 = false;
    private bool isClickText = false;
    private bool issafe = false;
    public bool isAxe = false;
    public enemy enm;
    public GameObject ElectroPIC;
    public GameObject maintext;
    public GameObject runtext;
    public GameObject maintext1;
    public GameObject maintext2;
    public GameObject safetext;
    public GameObject enem;
    public Text healthText;
    public GameObject placed;
    public GameObject MainDoor;
    public GameObject Teleport;
    public GameObject Zadveryma;
    public GameObject enmtrigg;
    public GameObject triggerbedroom;
    public GameObject triggerelectro;
    private float timetowrite = 2f;
    private float timetostop = 0f;
    private float timetowrite1 = 2f;
    private float timetostop1 = 0f;
    private float timetowrite2 = 2f;
    private float timetostop2 = 0f;
    private float timetowrite3 = 2f;
    private float timetostop3 = 0f;
    private float timetowrite4 = 2f;
    private float timetostop4 = 0f;
    public int health = 7;
    public int enemHealth = 10;
    void Start()
    {
        health = PlayerPrefs.GetInt("health", health);
        healthText.text = " здоров'я: " + health;
        
    }

   
    void Update()
    {
        Debug.Log(enemHealth);
        healthText.text = health + " здоров'я";
        if (isClickText)
        {

            runtext.SetActive(true);
            timetowrite4 -= Time.deltaTime;

            if (timetostop4 >= timetowrite4)
            {
                runtext.SetActive(false);
                timetowrite4 = 0;
            }
        }
        if (isLock && isCabel && isPlank)
        {
            MainDoor.SetActive(false);
            Zadveryma.SetActive(false);
            Teleport.SetActive(true);
        }
        if (issafe)
        {

            safetext.SetActive(true);
            timetowrite3 -= Time.deltaTime;

            if (timetostop3 >= timetowrite3)
            {
                safetext.SetActive(false);
                timetowrite3 = 0;
            }
        }
        if (isEnter3)
        {
            maintext2.SetActive(true);
            timetowrite2 -= Time.deltaTime;

            if (timetostop2 >= timetowrite2)
            {
                maintext2.SetActive(false);
                timetowrite2 = 0;
            }
        }
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
                isLock = true;
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
                isPlank = true;
                
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
                ElectroPIC.SetActive(true);
            }
            if (hit.collider != null && hit.collider.tag == "pilers")
            {
                isPilers = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "cabel" && isPilers)
            {
                Destroy(hit.collider.gameObject);
                isCabel = true;
            }
            if (hit.collider != null && hit.collider.tag == "medic")
            {
                health += 1;
                Save();
                healthText.text = health + " здоров'я";
                //music.PlayOneShot(heal);
                hit.collider.gameObject.SetActive(false);
                if (health >= 7)
                {
                    health = 7;
                }
            }
            if (hit.collider != null && hit.collider.tag == "axe")
            {
                Destroy(hit.collider.gameObject);
                isAxe = true;   
            }
            if (hit.collider != null && hit.collider.tag == "enemy")
            {
                enemHealth -= 1;
                if (isAxe)
                {
                    enemHealth -= 2;
                }
                if (enemHealth <= 0)
                {
                    Destroy(enem);
                }
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
        if (collision.gameObject.tag == "doorf")
        {
            isEnter3 = true;    
        }
        if (collision.gameObject.tag == "safe2")
        {
            issafe = true;
        }
        if (collision.gameObject.tag == "enemy")
        {
            health -= 1;
            
            UpdateText();
        }





    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "emt")
        {
            isClickText = true; 
            enem.SetActive(true);
            enm.isenter = true;
            enmtrigg.SetActive(false);
        }
       
    }
    public void CloseElectro()
    {
        ElectroPIC.SetActive(false);
    }
    private void Save()
    {
        PlayerPrefs.SetInt("health", health);
    }
    private void UpdateText()
    {
        healthText.text = " здоров'я : " + health;
    }
}
