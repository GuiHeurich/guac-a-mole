using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject life1, life2, life3, gameover;
    public static int life;

    // Start is called before the first frame update
    void Start()
    {
        // unpause/normal timeflow
        Time.timeScale = 1;

        setStartingLives();

        gameover.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enforceMaximumLives();

        switch (life)
        {
            case 3:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                break;

            case 2:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                break;

            case 1:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                break;

            case 0:
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);

                gameOver();
                break;
        }
    }

    void setStartingLives()
    {
        life = 3;
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
    }

    void enforceMaximumLives()
    {
        if (life > 3)
            life = 3;
    }

    void gameOver()
    {
        gameover.gameObject.SetActive(true);

        // freeze timeflow
        Time.timeScale = 0;
    }
}
