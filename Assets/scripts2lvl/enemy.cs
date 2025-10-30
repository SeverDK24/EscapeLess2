using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{

    [SerializeField] Transform target;
    public int rad = 2;
    public bool isenter = false;
    NavMeshAgent agent; 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false; 
    }

   
    void Update()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position,rad);
        if (isenter && hit..tag == "player")
        {
            agent.SetDestination(target.position);
        }
         
    }
    

     void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rad);
    }
   

}
