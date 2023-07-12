using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Transform playerSpawnTransform;
    [SerializeField] private ArmedEnemyController enemyController;
    [SerializeField] private CameraMovement cameraMovement;
    private PlayerController _player;
    private float _timer;
    private float _spawnInterval = 3f;


    public void Init(InputController inputController)
    {
        _player = Instantiate(playerController, playerSpawnTransform.position, Quaternion.identity);
        _player.Init(inputController);
        cameraMovement.Init(_player.transform);
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0f)
        {
            GameEvents.Instance.SpawnEnemy(_player);
            _timer = _spawnInterval;
        }
    }
}
