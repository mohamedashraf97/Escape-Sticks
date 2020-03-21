using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{

public Text gameOver;
public Player player;


    void Start()
    {
        gameOver = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    if(player.dead == true){

        gameOver.text = "GAME OVER" ;
    }
    }
}
