using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoSingleton<GameEvents>
{
    public event Action<PlayerController> OnEnemySpawn;
    public event Action OnEnemyDie;
    public event Action OnPlayerDie;

    public void SpawnEnemy(PlayerController player) => OnEnemySpawn?.Invoke(player);
    public void KillEnemy() => OnEnemyDie?.Invoke();
    public void PlayerLose() => OnPlayerDie?.Invoke();

}
