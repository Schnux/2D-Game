using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    //public float lookRadius = 10f;

    public float speed;

      Transform target;
    //NavMeshAgent agent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //target = PlayerE.instance.Player.transform;
          //agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {


        if(Vector2.Distance(transform.position, target.position) > 20)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


        //float distance = Vector3.Distance(target.position, transform. position);

        //if (distance <= lookRadius)
        //{
         //   agent.SetDestination(target.position);
        //}

    }

    //void OnDrawGizmosSelected()
    //{
      //  Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, lookRadius);
    //}

}
