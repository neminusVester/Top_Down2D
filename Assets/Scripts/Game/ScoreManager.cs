using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void Init()
    {
        GameEvents.Instance.OnEnemyDie += CountKilledEnemies;
        GameEvents.Instance.OnEnemyDie += CountMaxScore;
    }

    private void OnDestroy()
    {
        GameEvents.Instance.OnEnemyDie -= CountKilledEnemies;
        GameEvents.Instance.OnEnemyDie -= CountMaxScore;
    }

    private void CountKilledEnemies()
    {
        score += 1;
    }

    private void CountMaxScore()
    {
        if(score > SLS.Data.MaxScore.Value)
        {
            SLS.Data.MaxScore.Value = score;
        }
    }

}
