using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public int enemyCount;

    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }

    }
}
