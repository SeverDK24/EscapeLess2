using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstTOsecond : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "exit")
        {
            SceneManager.LoadScene(2);
        }
    }
}
