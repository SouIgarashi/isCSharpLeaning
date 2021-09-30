using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputModel : IInput
{
    public Action<Vector2> InputEvent { get; set; }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            InputEvent?.Invoke(new Vector2(0, 1));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            InputEvent?.Invoke(new Vector2(0, -1));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            InputEvent?.Invoke(new Vector2(1, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            InputEvent?.Invoke(new Vector2(-1, 0));
        }
    }
}
