using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour,IPlayer
{
    public Transform TransformData { get { return this.transform; } }

    public void UpdatePos(Vector2 pos)
    {
        this.transform.position += new Vector3(pos.x,pos.y,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
