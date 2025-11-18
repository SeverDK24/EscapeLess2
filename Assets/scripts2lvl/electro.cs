using UnityEngine;

public class electro : MonoBehaviour
{
    public GameObject replaced;
    public GameObject placed;
    private float timetowrite = 0.5f;
    private float timetostop = 0f;
    public GameObject safek;
    public GameObject safek1;
    public GameObject first;
    public GameObject last;
    private bool isClicked1 = false;
    public AudioSource music;
    public AudioClip electbutton;


    void Start()
    {
        music = GetComponent<AudioSource>();    
    }

    
    void Update()
    {
      
       if (isClicked1)
        {
           
            timetowrite -= Time.deltaTime;
            placed.SetActive(false);
            replaced.SetActive(true);
            safek.SetActive(true );
            safek1.SetActive(false );
            if (timetostop >= timetowrite)
            {
                gameObject.SetActive(false);
                timetowrite = 0;
            }
           
        }
    }
    public void Dissapear()
    {
       
        isClicked1 = true;
       
        
        
    }
    //public void Audio()
    //{
    //    music.PlayOneShot(electbutton);
    //}
}
