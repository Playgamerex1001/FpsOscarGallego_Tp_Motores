using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nave : MonoBehaviour
{
    
    public NavMeshAgent agent;
    public Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        InvokeRepeating("SetDestination", 5f, 1f);
    }

    
    void Update()
    {
        
    }

    public void SetDestination() 
    {
        agent.destination = player.position;
    }
}
