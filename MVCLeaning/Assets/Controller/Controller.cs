using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private IPlayer player;

    private IInput input;

    void Start()
    {
        input = new KeyboardInputModel();

        input.InputEvent += vec2 =>
        {
            player?.UpdatePos(vec2);
        };
    }

    void Update()
    {
        input.Update();
        if (Input.GetKeyDown(KeyCode.P))
        {
            player = GameObject.Find("Player").GetComponent<PlayerView>();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player = GameObject.Find("Enemy").GetComponent<EnemyView>();
        }
    }
}

