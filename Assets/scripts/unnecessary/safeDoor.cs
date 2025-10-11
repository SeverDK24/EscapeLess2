using UnityEngine;

public class safeDoor : MonoBehaviour
{

    public GameObject textInteract;
    private float openTime = 3f;
    public float timer;


    void Start()
    {

    }


    void Update()
    {

      


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {

            textInteract.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.transform.position = new Vector2(100, 100);
                textInteract.SetActive(false);

            }



        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {

            textInteract.SetActive(false);

        }
    }
}
