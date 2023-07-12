using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private LevelController levelController;
    [SerializeField] private InputController inputController; 
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private CanvasController canvasController;   

    private void Start()
    {
        levelController.Init(inputController);    
        scoreManager.Init();
        canvasController.Init(scoreManager); 

    }
}
