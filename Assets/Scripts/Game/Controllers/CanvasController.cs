using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playingScoreText;
    [SerializeField] private TextMeshProUGUI maxScoreText;
    [SerializeField] private GameObject gameOverPanel;
    private ScoreManager _scoreManager;

    public void Init(ScoreManager scoreManager)
    {
        _scoreManager = scoreManager;
        GameEvents.Instance.OnEnemyDie += SetPlayingScoreValue;
        GameEvents.Instance.OnPlayerDie += GameOver;
        SetMaxScore();
    }

    private void OnDestroy()
    {
        GameEvents.Instance.OnEnemyDie -= SetPlayingScoreValue;
        GameEvents.Instance.OnPlayerDie -= GameOver;
    }

    private void SetPlayingScoreValue()
    {
        playingScoreText.text = _scoreManager.score.ToString();
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive();
    }

    private void SetMaxScore()
    {
        maxScoreText.text = SLS.Data.MaxScore.Value.ToString();
    }
}
