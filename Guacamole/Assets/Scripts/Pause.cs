﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausebutton;
    public GameObject pausemessage;
    public GameObject shield;
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        pausebutton.gameObject.SetActive(true);
        pausemessage.gameObject.SetActive(false);
        shield.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
        {
            pausemessage.gameObject.SetActive(true);
            shield.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        else
        {
            pausemessage.gameObject.SetActive(false);
            shield.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

    }

    void OnMouseDown()
    {
        if (pause)
        {
            pause = false;
        }

        else
        {
            pause = true;
        }
    }
}
