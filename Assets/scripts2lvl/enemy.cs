using Unity.VisualScripting;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{

    [SerializeField] Transform target;
    public float rad = 1.4f;
    public bool isenter = false;
    [SerializeField] Transform point;
    [SerializeField] Transform point1;
    public Transform point2;
    public Transform point3;
    NavMeshAgent agent; 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false; 
    }
   
   
    void Update()
    {
        agent.SetDestination(point.position);
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position,rad);
        foreach (Collider2D hit in hits)
        {
            if (hit.gameObject.GetComponent<Reycast2LVL>() && isenter)
            {
                agent.SetDestination(target.position);
            }
            //if ((!hit.gameObject.GetComponent<Reycast2LVL>()) && isenter)
            //{
            //    agent.SetDestination(point.position);
            //}

        }
         
    }
    

     void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rad);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "first")
        {
            agent.SetDestination(point1.position);
        }

        if (collision.gameObject.tag == "sec")
        {
            agent.SetDestination(point2.position);
        }
        if (collision.gameObject.tag == "thrd")
        {
            agent.SetDestination(point3.position);
        }

    }
}
