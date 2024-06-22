using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDelay = 2f;
    public float radiusSpawn = 10f;
    private Vector3 spawnPoint;

    private void Start()
    {        
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            float spawnPointx = Random.Range(-radiusSpawn, radiusSpawn);
            float spawnPointy = Random.Range(-radiusSpawn, radiusSpawn);
            spawnPoint = new Vector3(spawnPointx, spawnPointy, 0);
            float scare = spawnPoint.magnitude / radiusSpawn;
            spawnPoint = new Vector3(spawnPoint.x / scare, spawnPoint.y / scare, 0);

            GameObject enemy = Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);

            Vector3 direction = enemy.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            enemy.transform.rotation = Quaternion.Euler(0f, 0f, angle);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
