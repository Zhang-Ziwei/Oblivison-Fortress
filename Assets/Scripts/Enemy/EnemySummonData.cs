using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySummonData", menuName = "ScriptableObjects/EnemySummonData")]
public class EnemySummonData : ScriptableObject
{
    public GameObject EnemyPrefab;
    public int EnemyID;
}