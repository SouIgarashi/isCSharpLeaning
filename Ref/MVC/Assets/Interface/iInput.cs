using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    Action<Vector2> InputEvent { get; set; }
    void Update();
}
