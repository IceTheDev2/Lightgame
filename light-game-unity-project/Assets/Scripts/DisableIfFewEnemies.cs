using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfFewEnemies : MonoBehaviour
{
    void Start()
    {
        Debug.Log(EnemySpawner.Instance.currentEnemyCount);
        if (EnemySpawner.Instance.currentEnemyCount < 8)
        {
            Destroy(gameObject);
        }
    }
}
