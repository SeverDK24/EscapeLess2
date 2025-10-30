using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{

    [SerializeField] Transform target;
   
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
        if (isenter)
        {
            agent.SetDestination(target.position);
        }
         
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
        
    
    //}
   
}
