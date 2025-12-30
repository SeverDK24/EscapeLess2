using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondTOthird : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "telep")
        {
            SceneManager.LoadScene(3);
        }
    }
}
