using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyReycast : MonoBehaviour
{
    private bool IsKotel = false;
    private bool isGarage = false;
    private bool isSkot = false;
    private bool isSafe = false;

    private bool IsOpened;
    public GameObject main;
    public GameObject textSafe;
    public GameObject textSafe1;
    public GameObject maintext;
    public GameObject behindDoor;
    private float timetowrite = 2f;
    private float timetostop = 0f;
    private float timetowrite2 = 2f;
    private float timetostop2 = 0f;
    private float timetowrite3 = 2f;
    private float timetostop3 = 0f;
    private float timetowrite1 = 2f;
    private float timetostop1 = 0f;
    private int codeAmount = 0;
    private int health = 13;
    public Text codeText;
    public Text healthText;
    private bool isEnter = false;
    private bool isClaimed = false;
    private bool isMainEnter = false;
    private bool isAllClaimed = false;
    public AudioSource music;
    //public AudioClip openDoor;
    public AudioClip scream;
    public AudioClip screamer;
    public GameObject[] ghosts;
    private int randomGhost;
    private int ghostRandom;
    private float timeToEvent = 12f;
    private float timeEvent = 0f;
    private float timeToDespawn = 1f;
    private bool isGhost = false;


    void Start()
    {
        healthText.text = health + " здоров'я";
       music = GetComponent<AudioSource>(); 
    }


    void Update()
    {
        healthText.text = health + " здоров'я";
        timeToEvent -= Time.deltaTime;
        //Debug.Log(timeToEvent);
        Debug.Log(ghostRandom);
        if (timeEvent >= timeToEvent)
        {
            ghostRandom = Random.Range(0, 3);
            if (ghostRandom == 0)
            {
                timeToEvent = 15f;

            }
            if (ghostRandom == 1)
            {
                ghostRandom = Random.Range(0, 3);
                ghosts[ghostRandom].SetActive(true);
                music.PlayOneShot(screamer);
                health -= 1;
                isGhost = true;
                timeToEvent = 15f;
            }
            if (ghostRandom == 2)
            {
                music.PlayOneShot(scream);
            }




        }





        if (isGhost)
        {
            timeToDespawn -= Time.deltaTime;
            if (timeEvent >= timeToDespawn)
            {
                ghosts[ghostRandom].SetActive(false);

                isGhost = false;
                timeToDespawn = 2f;
            }



        }


        if (isClaimed)
        {
            behindDoor.SetActive(false);    
        }

        if (isEnter)
        {
            maintext.SetActive(true);
            timetowrite2 -= Time.deltaTime;

            if (timetostop2 >= timetowrite2)
            {
                maintext.SetActive(false);
                timetowrite2 = 0;
            }
        }
        //if (IsOpened)
        //{
        //    timetowrite -= Time.deltaTime;

        //    if (timetostop >= timetowrite)
        //    {
        //        textSafe.SetActive(false);
        //        timetowrite = 0;
        //    }
        //}
        //if (issafeapproached)
        //{
        //    timetowrite1 -= Time.deltaTime;

        //    if (timetostop1 >= timetowrite1)
        //    {
        //        textSafe1.SetActive(false);
        //        timetowrite1 = 0;
        //    }
        //}

        
    

        //    Debug.Log("safe" + isSafe);
        //    Debug.Log("garage" + isGarage);
        //    Debug.Log("kotel" + IsKotel);
        //    Debug.Log("skot" + isSkot);
        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null && hit.collider.tag == "key")
            {
                Destroy(hit.collider.gameObject);
                IsKotel = true;
            }
            if (hit.collider != null && hit.collider.tag == "safeKey")
            {
                Destroy(hit.collider.gameObject);
                isSafe = true;
            }
            if (hit.collider != null && hit.collider.tag == "GarageKey")
            {
                isGarage = true;
                Destroy(hit.collider.gameObject);
              

            }
            if (hit.collider != null && hit.collider.tag == "SkotKey")
            {
                Destroy(hit.collider.gameObject);
                isSkot = true;

            }
           if (hit.collider != null && hit.collider.tag == "GarageDoor" && isGarage)
            {
                Destroy(hit.collider.gameObject);
            }
           if (hit.collider != null && hit.collider.tag == "KotelDoor" && IsKotel)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "SkotDoor" && isSkot)
            {
                Destroy(hit.collider.gameObject);
            }
           
            if (hit.collider != null && hit.collider.tag == "SafeDoor" && isSafe)
            {
                Destroy(hit.collider.gameObject);
            }


            if (hit.collider != null && hit.collider.tag == "code")
            {
                codeAmount += 1;
                codeText.text = "зібрано " + codeAmount + "/5";
                hit.collider.gameObject.SetActive(false);
                if (codeAmount == 5)
                {
                 isClaimed = true;
                }
            }
            if (hit.collider != null && hit.collider.tag == "medic")
            {
                health += 1;
                healthText.text = health + " здоров'я";
                hit.collider.gameObject.SetActive(false);
                if (health >= 15)
                {
                    health = 14;
                }
            }
            if (hit.collider != null && hit.collider.tag == "main" && (isClaimed = true))
            {
                hit.collider.gameObject.SetActive(false);
              isAllClaimed = true;  
            }
           










        }
        
    }
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "safe")
    //    {
    //        issafeapproached = true;
    //        textSafe1.SetActive(true);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "main")
        {
            isEnter = true; 
        }
    }
    

}
