using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent; 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false; 
    }

   
    void Update()
    {
        agent.SetDestination(target.position);  
    }
}
