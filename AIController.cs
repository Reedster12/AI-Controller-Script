using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private GameObject destination;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Destination");

        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(destination.transform.position);
    }
}
