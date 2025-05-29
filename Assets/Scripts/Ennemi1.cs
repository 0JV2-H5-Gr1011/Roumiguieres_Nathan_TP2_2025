using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemi1 : MonoBehaviour
{
    
    [SerializeField] private Transform _cible;
    private NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        BougerAgent();
    }

    void BougerAgent()
    {
        _agent.SetDestination(_cible.position);
    }
}
