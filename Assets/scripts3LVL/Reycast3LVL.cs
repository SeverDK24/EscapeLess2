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
    public GameObject imageRight;
    public GameObject imageWrong;
    public GameObject Safe;
    public int health = 7;
    private int insertcounting;
    private float timewrite = 2f;
    private float timestop = 0f;
    private float timewrite1 = 2f;
    private float timestop1 = 0f;
    private bool iscorid = false;
    private bool ismaincode = false;
    private bool iscodeopened = true;
    private bool isone = false;
    private bool istwo = false;
    private bool isthree = false;
    private bool isfour = false;
    private bool isfive = false;
    private bool issix = false;
    private bool iscodetrue = false;
    private bool iscodefalse = false;
    //public AudioSource music;

    void Start()
    {
        health = PlayerPrefs.GetInt("health", health);
        healthText.text = " здоров'я: " + health;
        //music = GetComponent<AudioSource>();
    }


    void Update()
    {
        Debug.Log(issix);

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

        if (iscodefalse)
        {
            timewrite1 -= Time.deltaTime;
            if (timestop1 >= timewrite1)
            {
                imageWrong.SetActive(false);
                insertcounting = 0;

            }

        }
        if (istwo && isthree && issix)
        {
            imageRight.SetActive(true); 
            iscodetrue = true;
        }
        if (insertcounting == 3 && istwo == false)
        {
            imageWrong.SetActive(true); 
            iscodefalse = true;

        }

        if (health >= 7)
        {
            health = 7;
        }
        Debug.Log(ismaincode);
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
}