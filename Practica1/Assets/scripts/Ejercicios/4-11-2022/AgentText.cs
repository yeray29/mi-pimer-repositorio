using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentText : MonoBehaviour
{
    public NavMeshAgent myAgent;
    public Transform destination;

    private void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        myAgent.destination = destination.position;
    }
}