using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView :MonoBehaviour,IPlayer
{
    public Transform TransformData { get { return this.transform; } }

    public void UpdatePos(Vector2 pos)
    {
        this.TransformData.position += new Vector3(pos.x, pos.y, 0);
    }
}