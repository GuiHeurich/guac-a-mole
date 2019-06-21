using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + scoreValue;
        
    }

    public void increase(int value) 
    {
        scoreValue += value;
    }

    public int getScoreValue()
    {
        return scoreValue;
    }

    public void setScoreValue(int value)
    {
        scoreValue = value;
    }
}
