using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints = new Transform[8];
    public GameObject enemy;
    float timer;
    public float cooldown;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            FixedSpawn(2);
            timer = 0;
        }
    }

    void FixedSpawn(int enemyNumb)
    {
        foreach (Transform t in spawnPoints)
        {
            for (int i = 0; i < enemyNumb; i++) 
            {
                Instantiate(enemy, t.position, enemy.transform.rotation);
            }
        }
    }

    void RandomSpawn(int enemyNumb)
    {
        for (int i = 0; i < enemyNumb; i++)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, enemy.transform.rotation);

        }
    }
}
