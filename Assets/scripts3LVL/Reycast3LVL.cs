
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;
public class Reycast3LVL : MonoBehaviour
{
    public GameObject Zadveryma;
    public Text healthText;
    public GameObject CodeMainText;
    public GameObject code6;
    public GameObject code2;
    public GameObject code3;
    public GameObject codeimage;
    public GameObject codeimage1;
    public GameObject imageRight;
    //public GameObject imageWrong;
    public GameObject Safe;
   
    public int health = 7;
   
    private int insertcounting;
    private float timewrite = 2f;
    private float timestop = 0f;
    private float timewrite1 = 2f;
    private float timestop1 = 0f;
    private float timewrite2 = 2f;
    private float timestop2 = 0f;
    private float timewrite3 = 2f;
    private float timestop3 = 0f;
    private float timewrite4 = 2f;
    private float timestop4 = 0f;
    private float timewrite5 = 2f;
    private float timestop5 = 0f;
    private float timewrite6 = 2f;
    private float timestop6 = 0f;
    private float timewrite7 = 2f;
    private float timestop7 = 0f;
    private float timeinsert = 2f;
    private float timedestroy = 0f;
    private float timeinsert1 = 20f;
    private float timedestroy1 = 0f;
    private float timetowrite = 2f;
    private float timetostop = 0f;
    private float timetowrite1 = 2f;
    private float timetostop1 = 0f;
    private float timetowrite2 = 2f;
    private float timetostop2 = 0f;
    private bool iscorid = false;
    private bool ismaincode = false;
    private bool iscodeopened = true;
    private bool iscodeopened1 = true;
    private bool isone = false;
    private bool istwo = false;
    private bool isthree = false;
    private bool isfour = false;
    private bool isfive = false;
    private bool issix = false;
    private bool iscodetrue = false;
    private bool iscodefalse = false;
    private bool isgas = false;
    private bool ispoisonget = false;
    private bool ispoisonget1 = false;
    private bool iszombietext = false;
    private bool ispoison = false;
    private bool isstorage = false;
    private bool issafe = false;
    private bool isbar = false;
    private bool isjail = false;    
    private bool isAxe = false;
    private bool isham = false;
    private bool isbreaknotreal = false;
    private bool isbreakreal = false;
    private bool ismop = false;
    private bool isgassprayed = false;
    private bool isknife = false;
    public bool isart = false;
  
    public GameObject enem;
    public GameObject enem1;
    public GameObject enem2;
    public GameObject enem3;
    public GameObject enem4;
    public GameObject enemzomb1;
    public GameObject enemzomb2;
    public GameObject enemzomb3;
    public GameObject poisonBath;
    public GameObject poisonCage;
    public GameObject zombtext;
    public GameObject safetext;
    public GameObject safeaxetext;
    public GameObject artext;
    public GameObject cage;
    public GameObject safe;
    public GameObject mop;
    public GameObject portal;
    public GameObject portal2;
    public GameObject barrier;
    public GameObject mainbarrier;
    public Transform transf;
    public Transform transf1;
    public int enemHealth = 10;
    public int enemHealth1 = 10;
    public int enemHealth2 = 10;
    public int enemHealth3 = 10;
    public int enemHealth4 = 10;
    public int enemHealthZomb1 = 5;
    public int enemHealthZomb2 = 5;
    public int enemHealthZomb3 = 5;
    public int SafeHeal = 10;
    private int randomGhost;
    private int ghostRandom;
    private float timeToEvent = 12f;
    private float timeEvent = 0f;
    private float timeToDespawn = 1f;
    private bool isGhost = false;
    public GameObject[] ghosts;
    public AudioSource music;
    public AudioClip key;
    public AudioClip gasleak;
    public AudioClip heal;
    public AudioClip openDoor;
    public AudioClip scream;
    public AudioClip screamer;
    public AudioClip locck;
    public AudioClip planks;
    public AudioClip electron;
    public AudioClip art;
    public AudioClip enemySpawn;
    public AudioClip enemyHit;
    public AudioClip enemyDamage;
    public AudioClip axe;
    public AudioClip code;
    public AudioClip mirror;
    public AudioClip safes;
    public AudioClip gasspray;
    public AudioClip picking;
    public AudioClip blood;
    public AudioClip safehit;
    public AudioClip portall;

    void Start()
    {
        health = PlayerPrefs.GetInt("health", health);
        healthText.text = " здоров'я: " + health;
        //music = GetComponent<AudioSource>();
    }


    void Update()
    {
        timeToEvent -= Time.deltaTime;

        Debug.Log("isart"+isart);
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
        if (isart)
        {
            artext.SetActive(true);
            portal2.SetActive(true);
        }
        Debug.Log(ismop);
        UpdateText();   
        if (SafeHeal <= 0)
        {
            Destroy(safe);
            
          
        }
        if (isart)
        {
            artext.SetActive(true);
            timetowrite2 -= Time.deltaTime;

            if (timetostop2 >= timetowrite2)
            {
                artext.SetActive(false);
                timetowrite2 = 0;
            }
        }
        if (isbreaknotreal)
        {
            safetext.SetActive(true);
            timetowrite -= Time.deltaTime;

            if (timetostop >= timetowrite)
            {
                safetext.SetActive(false);
                timetowrite = 0;
            }
        }
        if (isbreakreal)
        {
            safeaxetext.SetActive(true);
            timetowrite1 -= Time.deltaTime;

            if (timetostop1 >= timetowrite1)
            {
                safeaxetext.SetActive(false);
                timetowrite1 = 0;
            }
        }

        if (iszombietext)
        {
            zombtext.SetActive(true);
            timewrite7 -= Time.deltaTime;

            if (timestop7 >= timewrite7)
            {
                zombtext.SetActive(false);
                timewrite7 = 0;
            }
        }
        if (ispoisonget)
        {
            timeinsert -= Time.deltaTime;
            if (timeinsert <= timedestroy)
            {
                poisonBath.SetActive(false);
                ispoisonget1 = true;
            }
        }
        if (ispoisonget1)
        {
            
            poisonCage.SetActive(true);
            Destroy(enemzomb1);
            Destroy(enemzomb2);
            Destroy(enemzomb3);
            timeinsert1 -= Time.deltaTime;
            if (timeinsert1 <= timedestroy1)
            {
                poisonCage.SetActive(false);
            }
        }
        if (iscodetrue)
        {
            timewrite -= Time.deltaTime;
            if (timestop >= timewrite)
            {
                imageRight.SetActive(false);
                codeimage.SetActive(false);
                Safe.SetActive(false);

            }

        }
        if (issix)
        {
            timewrite6 -= Time.deltaTime;
            if (timestop6 >= timewrite6)
            {
                issix = false;
                timewrite6 = 3f;

            }
        }
        if (isone)
        {
            timewrite1 -= Time.deltaTime;
            if (timestop1 >= timewrite1)
            {
                isone = false;
                timewrite1 = 3f;

            }
        }
        if (istwo)
        {
            timewrite2 -= Time.deltaTime;
            if (timestop2 >= timewrite2)
            {
                istwo = false;
                timewrite2 = 3f;

            }
        }
        if (isthree)
        {
            timewrite3 -= Time.deltaTime;
            if (timestop3 >= timewrite3)
            {
                isthree = false;
                timewrite3 = 3f;

            }
        }
        if (isfour)
        {
            timewrite4 -= Time.deltaTime;
            if (timestop4 >= timewrite4)
            {
                isfour = false;
                timewrite4 = 3f;

            }
        }
        if (isfive)
        {
            timewrite5 -= Time.deltaTime;
            if (timestop5 >= timewrite5)
            {
                isfive = false;
                timewrite5 = 3f;

            }
        }
       


        //if (iscodefalse)
        //{
        //    timewrite1 -= Time.deltaTime;
        //    if (timestop1 >= timewrite1)
        //    {
        //        imageWrong.SetActive(false);
        //        insertcounting = 0;

        //    }

        //}
        if (istwo && isthree && issix)
        {
            imageRight.SetActive(true); 
            iscodetrue = true;
        }
        //if (insertcounting == 3 && istwo == false)
        //{
        //    imageWrong.SetActive(true); 
        //    iscodefalse = true;

        //}

        if (health >= 7)
        {
            health = 7;
        }
        
        
        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null && hit.collider.tag == "door")
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "mirror")
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(mirror);
            }
            if (hit.collider != null && hit.collider.tag == "code")
            {
                music.PlayOneShot(code);
                Destroy(hit.collider.gameObject);
                code6.SetActive(true);
                if (ismaincode == false)
                {
                    CodeMainText.SetActive(true);
                    ismaincode = true;
                }


            }
            if (hit.collider != null && hit.collider.tag == "code2")
            {
                music.PlayOneShot(code);
                Destroy(hit.collider.gameObject);
                code2.SetActive(true);
                if (ismaincode == false)
                {
                    CodeMainText.SetActive(true);
                    ismaincode = true;
                }

            }
            if (hit.collider != null && hit.collider.tag == "code3")
            {
                music.PlayOneShot(code);
                Destroy(hit.collider.gameObject);
                code3.SetActive(true);
                if (ismaincode == false)
                {
                    CodeMainText.SetActive(true);
                    ismaincode = true;
                }

            }
            if (hit.collider != null && hit.collider.tag == "medic")
            {
                music.PlayOneShot(heal);
                health += 1;
                music.PlayOneShot(heal);
                Save();
                healthText.text = health + " здоров'я";
                //music.PlayOneShot(heal);
                hit.collider.gameObject.SetActive(false);


            }
            if (hit.collider != null && hit.collider.tag == "corid")
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(key);
                iscorid = true;
            }

            if (hit.collider != null && hit.collider.tag == "coridor" && iscorid)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);
            }
            if (hit.collider != null && hit.collider.tag == "codesafe")
            {
                codeimage.SetActive(iscodeopened);
                music.PlayOneShot(safes);
                iscodeopened = !iscodeopened;
            }
            if (hit.collider != null && hit.collider.tag == "enemy")
            {
                music.PlayOneShot(enemyDamage);
                enemHealth -= 1;
                if (isAxe)
                {
                    enemHealth -= 2;
                    music.PlayOneShot(enemyDamage);
                }
                if (isknife)
                {
                    enemHealth -= 5;
                    music.PlayOneShot(enemyDamage);
                }

                if (enemHealth <= 0)
                {
                    Destroy(enem);
                    music.PlayOneShot(enemyHit);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy2")
            {
                music.PlayOneShot(enemyDamage);
                enemHealth1 -= 1;
                if (isAxe)
                {
                    enemHealth1 -= 2;
                    music.PlayOneShot(enemyDamage);
                }
                if (isknife)
                {
                    enemHealth1 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealth1 <= 0)
                {
                    Destroy(enem1);
                    music.PlayOneShot(enemyHit);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy3")
            {
                music.PlayOneShot(enemyDamage);
                enemHealth2 -= 1;
                if (isAxe)
                {
                    music.PlayOneShot(enemyDamage);
                    enemHealth2 -= 2;
                }
                if (isknife)
                {
                    music.PlayOneShot(enemyDamage);
                    enemHealth2 -= 5;
                }
                if (enemHealth2 <= 0)
                {
                    Destroy(enem2);
                    music.PlayOneShot(enemyHit);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy4")
            {
                music.PlayOneShot(enemyDamage);
                enemHealth3 -= 1;
                if (isAxe)
                {
                    enemHealth3 -= 2;
                    music.PlayOneShot(enemyDamage);
                }
                if (isknife)
                {
                    enemHealth3 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealth3 <= 0)
                {
                    Destroy(enem3);
                    music.PlayOneShot(enemyHit);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy5")
            {
                music.PlayOneShot(enemyDamage);
                enemHealth4 -= 1;
                if (isAxe)
                {
                    enemHealth4 -= 2;
                    music.PlayOneShot(enemyDamage);
                }
                if (isknife)
                {
                    enemHealth4 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealth4 <= 0)
                {
                    Destroy(enem4);
                    music.PlayOneShot(enemyHit);
                }
            }
            if (hit.collider != null && hit.collider.tag == "Respawn")
            {
                music.PlayOneShot(enemyDamage);
                enemHealthZomb1 -= 1;
                if (isAxe)
                {
                    enemHealthZomb1 -= 2;
                    music.PlayOneShot(enemyDamage);
                }
                if (isknife)
                {
                    enemHealthZomb1 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealthZomb1 <= 0)
                {
                    music.PlayOneShot(enemyHit);
                    Destroy(enemzomb1);
                    
                }
            }
            if (hit.collider != null && hit.collider.tag == "Finish")
            {
                music.PlayOneShot(enemyDamage);
                enemHealthZomb2 -= 1;
                if (isAxe)
                {
                    enemHealthZomb2 -= 2;
                }
                if (isknife)
                {
                    enemHealthZomb2 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealthZomb2 <= 0)
                {
                    music.PlayOneShot(enemyHit);
                    Destroy(enemzomb2);
                    
                }
            }
            if (hit.collider != null && hit.collider.tag == "safeDoor")
            {
                music.PlayOneShot(enemyDamage);
                enemHealthZomb3 -= 1;
                if (isAxe)
                {
                    enemHealthZomb3 -= 2;
                }
                if (isknife)
                {
                    enemHealthZomb3 -= 5;
                    music.PlayOneShot(enemyDamage);
                }
                if (enemHealthZomb3 <= 0)
                {
                    music.PlayOneShot(enemyHit);
                    Destroy(enemzomb3);
                }
            }
            if (hit.collider != null && hit.collider.tag == "gas")
            {
                Destroy(hit.collider.gameObject);   
                music.PlayOneShot(picking);
                isgas = true;
            }
            if (hit.collider != null && hit.collider.tag == "bathtub" && isgas == true)
            {
                poisonBath.SetActive(true);
                music.PlayOneShot(gasspray);
                isgassprayed = true;
                ispoisonget = true;
                
            }
            if (hit.collider != null && hit.collider.tag == "safe2")
            {
                music.PlayOneShot(safes);
                codeimage1.SetActive(iscodeopened1);
                iscodeopened1 = !iscodeopened1;
            }
            if (hit.collider != null && hit.collider.tag == "stor")
            {
                Destroy(hit.collider.gameObject); 
                isstorage = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "livingr" && isstorage)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);

            }
            if (hit.collider != null && hit.collider.tag == "srk")
            {
                Destroy(hit.collider.gameObject);
                issafe = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "tosafe" && issafe)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);

            }
            if (hit.collider != null && hit.collider.tag == "bar")
            {
                Destroy(hit.collider.gameObject);
                isbar = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "barack" && isbar)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);

            }
            if (hit.collider != null && hit.collider.tag == "mirror" )
            {
                music.PlayOneShot(mirror);
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "jailk")
            {
                Destroy(hit.collider.gameObject);
                isjail = true;
                music.PlayOneShot(key);
            }
            if (hit.collider != null && hit.collider.tag == "jail" && isjail)
            {
                Destroy(hit.collider.gameObject);
                music.PlayOneShot(openDoor);

            }
            if (hit.collider != null && hit.collider.tag == "axe")
            {
                music.PlayOneShot(axe);
                Destroy(hit.collider.gameObject);
                isAxe = true;
            }
            if (hit.collider != null && hit.collider.tag == "knife")
            {
                music.PlayOneShot(axe);
                Destroy(hit.collider.gameObject);
                isknife = true;
            }
            
            if (hit.collider != null && hit.collider.tag == "safe"&& isAxe == false )
            {
                isbreaknotreal = true;
                music.PlayOneShot(safes);
            }
            if (hit.collider != null && hit.collider.tag == "safe" && isAxe == true)
            {
                music.PlayOneShot(safehit);


                isbreakreal = true;
                SafeHeal -= 1;


            }
            if (hit.collider != null && hit.collider.tag == "mop" )
            {
               Destroy(hit.collider.gameObject);    
               ismop = true;
                music.PlayOneShot(picking);
            }
            if (hit.collider != null && hit.collider.tag == "blood" && ismop)
            {
                Destroy(hit.collider.gameObject);
                portal.SetActive(true);
                music.PlayOneShot(blood);



            }
            if (hit.collider != null && hit.collider.tag == "art")
            {
                Destroy(hit.collider.gameObject);
                isart = true;
                music.PlayOneShot(art);
            }
            if (hit.collider != null && hit.collider.tag == "exit" && isart)
            {
                Destroy(hit.collider.gameObject);
                Zadveryma.SetActive(false);
                music.PlayOneShot(openDoor);
               
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
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
        if (collision.gameObject.tag == "enemy3")
        {
            health -= 1;

            UpdateText();
        }
        if (collision.gameObject.tag == "enemy4")
        {
            health -= 1;

            UpdateText();
        }
        if (collision.gameObject.tag == "enemy5")
        {
            health -= 1;

            UpdateText();
        }
        if (collision.gameObject.tag == "Respawn")
        {
            health -= 1;
            UpdateText();
        }
        if (collision.gameObject.tag == "Finish")
        {
            health -= 1;
            UpdateText();
        }
        if (collision.gameObject.tag == "safeDoor")
        {
            health -= 1;
            UpdateText();
        }
       

        
        

    }
     void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ftrig")
        {
            
            SceneManager.LoadScene(3);
        }
        if (collision.gameObject.tag == "poison")
        {
           health -= 1;

        }
        if (collision.gameObject.tag == "portal")
        {
            barrier.SetActive(false);   
            mainbarrier.SetActive(true);
            transform.position = transf.position;
            music.PlayOneShot(portall);
        }
        if (collision.gameObject.tag == "portal2")
        {
            music.PlayOneShot(portall);
            mainbarrier.SetActive(false);
            barrier.SetActive(true);
            transform.position = transf1.position;
            portal.SetActive(false);
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("health", health);
    }
    public void ResetHealth()
    {
        health = 7;
        Save();
        UpdateText();
    }
    private void UpdateText()
    {
        healthText.text = "здоров'я : " + health;
    }
    public void One()
    {
        isone = true;
        insertcounting += 1;
    }
    public void Two()
    {
        istwo = true;
        insertcounting += 1;
    }
    public void Three()
    {
        isthree = true;
        insertcounting += 1;
    }
    public void Four()
    {
        isfour = true;
        insertcounting += 1;
    }
    public void Five()
    {
        isfive = true;
        insertcounting += 1;
    }
    public void Six()
    {
        issix = true;
        insertcounting += 1;

    }
    public void Zombfree()
    {
        if (isgassprayed == false)
        {
            iszombietext = true;
        }
        if (isgassprayed == true)
        {
            cage.SetActive(false);
        }
    }
}