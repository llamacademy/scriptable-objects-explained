using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack Configuration", menuName = "Enemies/Attack Configuration", order = 20)]
public class AttackConfigurationScriptableObject : ScriptableObject
{
    public float AttackDelay = 0.5f;
    public int Damage = 10;
    public float Radius = 2.5f;
}
