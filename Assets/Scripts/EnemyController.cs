using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{

    public float lookRadius = 10f;

      Transform target;
    NavMeshAgent agent;

    void Start()
    {
        target = PlayerE.instance.Player.transform;
          agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector2.Distance(target.position, transform. position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}
