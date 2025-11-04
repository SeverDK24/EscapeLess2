using Unity.VisualScripting;
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
   //agent.SetDestination(target.position);
   
    void Update()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position,rad);
        foreach (Collider2D hit in hits)
        {
            if (hit.gameObject.GetComponent<Reycast2LVL>()&& isenter)
            {
                agent.SetDestination(target.position);
            }
        }
         
    }
    

     void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rad);
    }
   

}
