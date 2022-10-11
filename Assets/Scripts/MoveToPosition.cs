using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPosition : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    
    
    {
        //we cannot attach GameObject Player in Inspector when spawning
        //so we use code instead.
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();    
    }

    void Update() {
        agent.SetDestination(goal.position);
    }


}
