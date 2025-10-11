using UnityEngine;

public class raycastDoor : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        OpenDoor();  
    }
    public void OpenDoor()
    {
        Vector2 origin = transform.position;
        Vector2 direction = Vector2.left;
        RaycastHit2D hit = (Physics2D.Raycast(origin, direction, 3f));
        if (hit.collider.tag == "door")
        {
            gameObject.transform.position = new Vector2(100, 100);
        }





    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.forward * 3f);
    }
}
