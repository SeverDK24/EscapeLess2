using UnityEngine;
using UnityEngine.SceneManagement;
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
    private bool isClickText2 = false;
    private bool issafe = false;
    public bool isAxe = false;
    private bool iseltr;
    private bool isbtr;
    private bool iseltr1;
    private bool isbtr1;
    public Reycast3LVL art;
    public enemy2 enm2;
    public GameObject btr;
    public GameObject eltr;
    public GameObject ElectroPIC;
    public GameObject maintext;
    public GameObject runtext;
    public GameObject maintext1;
    public GameObject maintext2;
    public GameObject safetext;
   
    public GameObject enem2;
    public Text healthText;
    public GameObject placed;
    public GameObject MainDoor;
    public GameObject Teleport;
    public GameObject Zadveryma;
    public GameObject Zadveryma2;
    public GameObject enmtrigg2;
    public GameObject triggerbedroom;
    public GameObject triggerelectro;
    public GameObject pryv1;
    public GameObject pryv2;    
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
    private float timetowrite5 = 2f;
    private float timetostop5 = 0f;
    private float timepryv = 2f;
    private float timepryv1 = 2f;
    private float timedesp = 0f;
    private float timedesp1 = 0f;
    public int health = 7;
    public int enemHealth = 10;
    public int healthEnem = 10;
    private int randomGhost;
    private int ghostRandom;
    private float timeToEvent = 12f;
    private float timeEvent = 0f;
    private float timeToDespawn = 1f;
    private bool isGhost = false;
    
    public GameObject[] ghosts;
    public AudioSource music;
    public AudioClip key;
    
    public AudioClip heal;
    public AudioClip openDoor;
    public AudioClip scream;
    public AudioClip screamer;
    public AudioClip locck;
    public AudioClip planks;
    public AudioClip electron;

    public AudioClip enemySpawn;
    public AudioClip enemyHit;
    public AudioClip enemyDamage;
    public AudioClip axe;
    public AudioClip pilers;
    public AudioClip mirror;
    public AudioClip safe;
    void Start()
    {
        health = PlayerPrefs.GetInt("health", health);
        healthText.text = " здоров'я: " + health;
        music = GetComponent<AudioSource>();
        
    }

   
    void Update()
    {
        Debug.Log("isart" + art.isart);
        timeToEvent -= Time.deltaTime;

        
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
                Save();
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
        
       
        
        if (iseltr)
        {
            pryv2.SetActive(true);
           
           
            timepryv1 -= Time.deltaTime;
            if (timedesp1 >= timepryv1)
            {
                pryv2.SetActive(false);
                
            }
        
        }
        if (iseltr1)
        {
            updatehealth();
            Save();
            iseltr1 = false;    
        }
        if (isbtr)
        {

            pryv1.SetActive(true);
            
            timepryv -= Time.deltaTime;
            if (timedesp >= timepryv)
            {
                pryv1.SetActive(false);

            }
           
        }
        if (isbtr1)
        {
            updatehealth();
            Save();
            isbtr1 = false;
        }
       
        healthText.text = health + " здоров'я";
        if (isClickText2)
        {
            runtext.SetActive(true);
            timetowrite5 -= Time.deltaTime;

            if (timetostop5 >= timetowrite5)
            {
                runtext.SetActive(false);
                timetowrite5 = 0;
            }
        }
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
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "bedroomk")
            {
                isBedroomk = true;  
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);

            }
            if (hit.collider != null && hit.collider.tag == "Bedroom" && isBedroomk)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
           if (hit.collider != null && hit.collider.tag == "mirror" && isEnter1)
            {
                music.PlayOneShot(mirror);  
                Destroy(hit.collider.gameObject);
            }
           if (hit.collider != null && hit.collider.tag == "coridk")
            {
                isCoridk = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "safek")
            {
                isSafek = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "safe2" && isSafek)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(safe);
            }
            if (hit.collider != null && hit.collider.tag == "maink")
            {
                Destroy(hit.collider.gameObject);
                isMain = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "lock" && isMain)
            {
                Destroy(hit.collider.gameObject);
                isLock = true;
                music.PlayOneShot(locck);
            }
            if (hit.collider != null && hit.collider.tag == "kitchenk")
            {
                Destroy(hit.collider.gameObject);
                isKitchen = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "kitchen" && isKitchen)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "livingk")
            {
                isLivingk = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "livingr" && isLivingk)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "coridk")
            {
                isCoridk = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "coridor" && isCoridk)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "hammer")
            {
                isHammer = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(planks);
            }
            if (hit.collider != null && hit.collider.tag == "plank" && isHammer)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(planks);
                isPlank = true;
                
            }
            if (hit.collider != null && hit.collider.tag == "electrok")
            {
                isElectro = true;
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "electro" && isElectro)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);

            }
            if (hit.collider != null && hit.collider.tag == "button")
            {
                ElectroPIC.SetActive(true);
                music.PlayOneShot(electron);
            }
            if (hit.collider != null && hit.collider.tag == "pilers")
            {
                music.PlayOneShot(pilers);    
                isPilers = true;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "cabel" && isPilers)
            {
                music.PlayOneShot(pilers);
                Destroy(hit.collider.gameObject);
                isCabel = true;
            }
            if (hit.collider != null && hit.collider.tag == "medic")
            {
                health += 1;
                music.PlayOneShot(heal);
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
                music.PlayOneShot(axe); 
                Destroy(hit.collider.gameObject);
                isAxe = true;   
            }
            //if (hit.collider != null && hit.collider.tag == "enemy")
            //{
            //    music.PlayOneShot(enemyDamage);
            //    enemHealth -= 1;
            //    if (isAxe)
            //    {
            //        enemHealth -= 2;
            //    }
            //    if (enemHealth <= 0)
            //    {
            //        Destroy(enem);
            //    }
            //}
            if (hit.collider != null && hit.collider.tag == "enemy2")
            {
                music.PlayOneShot(enemyDamage);
                healthEnem -= 1;    
                if (isAxe)
                {
                    healthEnem -= 2;
                }
                if (healthEnem <= 0)
                {
                    Destroy(enem2);
                   //enem2.SetActive(false);
                }

            }
            if (hit.collider != null && hit.collider.tag == "houseexit" && art.isart)
            {
                Destroy(hit.collider.gameObject);
                Zadveryma2.SetActive(false);
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
        if (collision.gameObject.tag == "enemy2")
        {
            health -= 1;
            UpdateText();
        }





    }
    void OnTriggerEnter2D(Collider2D collision)
    {
    //    if (collision.gameObject.tag == "emt")
    //    {
    //        isClickText = true;
    //        music.PlayOneShot(enemySpawn);
    //        enem.SetActive(true);
    //        enm.isenter = true;
    //        enmtrigg.SetActive(false);
    //    }
        if (collision.gameObject.tag == "emmt")
        {
            isClickText2 = true;
            music.PlayOneShot(enemySpawn);
            enem2.SetActive(true);
            enm2.isenter = true;
            enmtrigg2.SetActive(false);


        }


       if (collision.gameObject.tag == "btr")
        {
            isbtr = true;
            music.PlayOneShot(screamer);
            isbtr1 = true;  
            Destroy(collision.gameObject);  
        }
       if (collision.gameObject.tag == "eltr")
        {
            iseltr = true;
            music.PlayOneShot(screamer);
            iseltr1 = true;
            Destroy(collision.gameObject);
        }
       if (collision.gameObject.tag == "end")
        {
            SceneManager.LoadScene(3);
        }
    }
    public void CloseElectro()
    {
        ElectroPIC.SetActive(false);
        music.PlayOneShot(electron);
    }
    private void Save()
    {
        PlayerPrefs.SetInt("health", health);
    }
    private void UpdateText()
    {
        healthText.text = " здоров'я : " + health;
    }
    public void ResetHealth()
    {
        health = 7;
        Save();
        UpdateText();
    }
    public void updatehealth()
    {
        health -= 1;
    }
}
