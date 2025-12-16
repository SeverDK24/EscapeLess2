using System;
using UnityEngine;
using UnityEngine.UI;
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
    //public AudioSource music;
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
    public GameObject cage;
    public int enemHealth = 10;
    public int enemHealth1 = 10;
    public int enemHealth2 = 10;
    public int enemHealth3 = 10;
    public int enemHealth4 = 10;
    public int enemHealthZomb1 = 5;
    public int enemHealthZomb2 = 5;
    public int enemHealthZomb3 = 5;

    void Start()
    {
        health = PlayerPrefs.GetInt("health", health);
        healthText.text = " здоров'я: " + health;
        //music = GetComponent<AudioSource>();
    }


    void Update()
    {
        Debug.Log(isbar);
        UpdateText();   
       
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
            }
            if (hit.collider != null && hit.collider.tag == "mirror")
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "code")
            {
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
                health += 1;
                //music.PlayOneShot(heal);
                Save();
                healthText.text = health + " здоров'я";
                //music.PlayOneShot(heal);
                hit.collider.gameObject.SetActive(false);


            }
            if (hit.collider != null && hit.collider.tag == "corid")
            {
                Destroy(hit.collider.gameObject);
                iscorid = true;
            }

            if (hit.collider != null && hit.collider.tag == "coridor" && iscorid)
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider != null && hit.collider.tag == "codesafe")
            {
                codeimage.SetActive(iscodeopened);
                iscodeopened = !iscodeopened;
            }
            if (hit.collider != null && hit.collider.tag == "enemy")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealth -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealth <= 0)
                {
                    Destroy(enem);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy2")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealth1 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealth1 <= 0)
                {
                    Destroy(enem1);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy3")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealth2 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealth2 <= 0)
                {
                    Destroy(enem2);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy4")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealth3 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealth3 <= 0)
                {
                    Destroy(enem3);
                }
            }
            if (hit.collider != null && hit.collider.tag == "enemy5")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealth4 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealth4 <= 0)
                {
                    Destroy(enem4);
                }
            }
            if (hit.collider != null && hit.collider.tag == "Respawn")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealthZomb1 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealthZomb1 <= 0)
                {
                    Destroy(enemzomb1);
                }
            }
            if (hit.collider != null && hit.collider.tag == "Finish")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealthZomb2 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealthZomb1 <= 0)
                {
                    Destroy(enemzomb2);
                }
            }
            if (hit.collider != null && hit.collider.tag == "safeDoor")
            {
                //music.PlayOneShot(enemyDamage);
                enemHealthZomb3 -= 1;
                //if (isAxe)
                //{
                //    enemHealth -= 2;
                //}
                if (enemHealthZomb3 <= 0)
                {
                    Destroy(enemzomb3);
                }
            }
            if (hit.collider != null && hit.collider.tag == "gas")
            {
                Destroy(hit.collider.gameObject);   
                isgas = true;
            }
            if (hit.collider != null && hit.collider.tag == "bathtub" && isgas == true)
            {
                poisonBath.SetActive(true);
                ispoisonget = true;
                
            }
            if (hit.collider != null && hit.collider.tag == "safe2")
            {
                codeimage1.SetActive(iscodeopened1);
                iscodeopened1 = !iscodeopened1;
            }
            if (hit.collider != null && hit.collider.tag == "stor")
            {
                Destroy(hit.collider.gameObject); 
                isstorage = true;   
            }
            if (hit.collider != null && hit.collider.tag == "livingr" && isstorage)
            {
                Destroy(hit.collider.gameObject);
                
            }
            if (hit.collider != null && hit.collider.tag == "srk")
            {
                Destroy(hit.collider.gameObject);
                issafe = true;
            }
            if (hit.collider != null && hit.collider.tag == "tosafe" && issafe)
            {
                Destroy(hit.collider.gameObject);

            }
            if (hit.collider != null && hit.collider.tag == "bar")
            {
                Destroy(hit.collider.gameObject);
                isbar = true;
            }
            if (hit.collider != null && hit.collider.tag == "barack" && isbar)
            {
                Destroy(hit.collider.gameObject);

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
        if (collision.gameObject.tag == "poison")
        {
           health -= 1;

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
        if (isgas == false)
        {
            iszombietext = true;
        }
        if (isgas == true)
        {
            cage.SetActive(false);
        }
    }
}