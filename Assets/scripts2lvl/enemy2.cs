using UnityEngine;
using UnityEngine.AI;

public class enemy2 : MonoBehaviour
{

    [SerializeField] Transform target;
    public float rad = 1.4f;
    public bool isenter = false;
    private bool istouch = false;
    private bool isTimer = false;
    [SerializeField] Transform point;
    [SerializeField] Transform point1;
    public Transform point2;
    public Transform point3;
    NavMeshAgent agent;
    private float timetoattack = 0f;
    private float attack = 1f;
    public Reycast2LVL health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        istouch = true;
    }


    void Update()
    {
        //if (isTimer)
        //{
        //    timetoattack += Time.deltaTime;
        //    if (timetoattack >= attack)
        //    {
        //        timetoattack = 0f;
        //        health.health -= 1;

        //    }
        //}
        agent.SetDestination(point.position);
        //if (istouch)
        //{
        //    agent.SetDestination(point.position);
        //}
        //;
        //if (point1touch)
        //{
        //    agent.SetDestination(point1.position);
        //}
        //if (point2touch)
        //{
        //    agent.SetDestination(point2.position);
        //}
        //if (point3touch)
        //{
        //    agent.SetDestination(point3.position);
        //}
        //if (point4touch)
        //{
        //    agent.SetDestination(point.position);  
        //}
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "player")
        //{
        //   isTimer = true;      
        //}

    }
}
