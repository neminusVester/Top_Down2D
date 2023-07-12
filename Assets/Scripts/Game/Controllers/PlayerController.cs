using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public InputController InputController => _inputController;
    private InputController _inputController;
    private Rigidbody2D _playerRb;
    private float _moveSpeed = 5f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Init(InputController newInputController)
    {
        _inputController = newInputController;
        _playerRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _playerRb.velocity = new Vector2(_inputController.GetMoveDirection().x * _moveSpeed, _inputController.GetMoveDirection().y * _moveSpeed);
    }


}
