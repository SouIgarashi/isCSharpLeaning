using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer
{
    Transform TransformData { get; }
    void UpdatePos(Vector2 pos);
}
