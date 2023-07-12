using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float _moveX;
    private float _moveY;
    private Vector2 _moveDirection;
    private Vector3 _mousePosition;
    

    public Vector2 GetMoveDirection()
    {
        _moveX = Input.GetAxisRaw("Horizontal");
        _moveY = Input.GetAxisRaw("Vertical");
        return _moveDirection = new Vector2(_moveX, _moveY).normalized;
    }

    public Vector3 GetMousePosition()
    {
        return _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

}
