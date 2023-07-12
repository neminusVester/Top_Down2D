using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private List<BaseEnemyController> enemies;
    [SerializeField] private Transform rightWall;
    [SerializeField] private Transform upWall;
    private Vector3 _enemyPosition;
    private float _spawnDistance = 10f;

    void Start()
    {
        GameEvents.Instance.OnEnemySpawn += SpawnEnemies;
    }

    private void OnDestroy()
    {
        GameEvents.Instance.OnEnemySpawn -= SpawnEnemies;
    }

    private void SpawnEnemies(PlayerController player)
    {
        Vector3 spawnPosition = GetRandomPosition();
        int randomIndex = Random.Range(0, enemies.Count);
        var enemy = Instantiate(enemies[randomIndex], spawnPosition, Quaternion.identity);
        enemy.Init(player);
        if (Vector3.Distance(spawnPosition, player.transform.position) < _spawnDistance)
        {
            Vector3 spawnDirection = (spawnPosition - player.transform.position).normalized;
            enemy.transform.position = player.transform.position + spawnDirection * _spawnDistance;
        }
    }

    private Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(-rightWall.position.x, rightWall.position.x);
        float randomY = Random.Range(-upWall.position.y, upWall.position.y);
        return _enemyPosition = new Vector3(randomX, randomY, 0f);
    }
}








