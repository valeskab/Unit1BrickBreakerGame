using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Debug.Log(touchPosition);
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);
            Debug.Log(worldPosition);
        }
    }
}
