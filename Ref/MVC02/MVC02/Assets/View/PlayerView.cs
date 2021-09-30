using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour,IPlayer
{
    public Transform TransformData { get { return this.transform; } } 

    public void UpdatePos(Vector2 pos)
    {
        this.transform.position += new Vector3(pos.x,0,pos.y);
    }
}
