using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private IPlayer player;

    private IInput input;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerView>();

        input = new KeyboardInputModel();
        input.InputEvent += vec2 =>
        {
            player.UpdatePos(vec2);
        };
    }

    void Update()
    {
        input.Update();
    }
}
