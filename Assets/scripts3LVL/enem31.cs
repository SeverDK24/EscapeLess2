using UnityEngine;
using UnityEngine.AI;

public class enem31 : MonoBehaviour
{
    [SerializeField] Transform target;
    public float rad = 2f;
    public bool isenter = false;
    private bool istouch = false;
    private bool isTimer = false;
    [SerializeField] Transform point;

    NavMeshAgent agent;
    private float timetoattack = 0f;
    private float attack = 1f;
    public Reycast3LVL health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        istouch = true;
    }


    void Update()
    {

        agent.SetDestination(point.position);

        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, rad);
        foreach (Collider2D hit in hits)
        {
            if (hit.gameObject.GetComponent<Reycast2LVL>() && isenter)
            {
                agent.SetDestination(target.position);
            }


        }

    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rad);
    }

}
