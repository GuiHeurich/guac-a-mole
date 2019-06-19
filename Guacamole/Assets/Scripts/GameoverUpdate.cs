using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverUpdate : MonoBehaviour
{
    Text gameover;


    // Start is called before the first frame update
    void Start()
    {
        gameover = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        if (ScoreUpdate.scoreValue < 1000)
        {
            gameover.text = "GAME OVER";
        }

        if (ScoreUpdate.scoreValue >= 1000 && ScoreUpdate.scoreValue < 5000)
        {
            gameover.text = "GOOD JOB!";
        }
        else if (ScoreUpdate.scoreValue >= 5000 && ScoreUpdate.scoreValue < 8000)
        {
            gameover.text = "GUAC-A-LICIOUS!";
        }

        else if (ScoreUpdate.scoreValue >= 8000 && ScoreUpdate.scoreValue < 15000)
        {
            gameover.text = "MOLE DESTROYER!";
        }

        else if (ScoreUpdate.scoreValue >= 15000 && ScoreUpdate.scoreValue < 50000)
        {
            gameover.text = "EXTERMINATOR!";
        }

        else if (ScoreUpdate.scoreValue > 50000)
        {
            gameover.text = "GUAAAAC?!";
        }

    }

}
