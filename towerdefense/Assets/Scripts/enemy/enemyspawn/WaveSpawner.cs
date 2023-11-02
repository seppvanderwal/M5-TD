using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawn;

    public float timeBetweenWaves = 5f;
    public float countdown = 2f;

    private int waveCount = 0;

    private void Update()
    {
        if (countdown <= 0) 
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
       for(int i = 0;i < waveCount; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.25f);
        }
        
        waveCount += 5;
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawn.position, spawn.rotation);
    }

}
