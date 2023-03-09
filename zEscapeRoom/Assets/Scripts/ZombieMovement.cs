using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{
    public GameObject zombieAimingFor;
    NavMeshAgent meshAgent;

    // Start is called before the first frame update
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        meshAgent.SetDestination(zombieAimingFor.transform.position);
    }
}
