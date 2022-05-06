using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemies/Enemy", order = 1)]
public class EnemyScriptableObject : ScriptableObject
{
    public int BaseHealth = 100;
    public float MoveSpeed = 2f;
    public float Height = 2;
    public int[] SomeIntegerValues = new int[] { 0, 5, 1, 2 };
    public AttackConfigurationScriptableObject AttackConfiguration;

    public void SetupNavMeshAgent(NavMeshAgent Agent)
    {
        //if (Enemy.TryGetComponent<NavMeshAgent>(out NavMeshAgent Agent))
        //{
            Agent.speed = MoveSpeed;
            Agent.height = Height;
        //} 
        //etc...
    }
}
