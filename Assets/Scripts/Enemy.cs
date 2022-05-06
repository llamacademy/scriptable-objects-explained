using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int Health;
    [SerializeField]
    private EnemyScriptableObject Configuration;

    private void Start()
    {
        Health = Configuration.BaseHealth;
        Configuration.SetupNavMeshAgent(GetComponent<NavMeshAgent>());
    }
}
