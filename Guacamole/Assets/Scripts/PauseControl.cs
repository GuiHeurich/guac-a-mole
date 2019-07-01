using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public GameObject pausebutton;
    public GameObject pausemessage;
    public GameObject shield;
    public bool paused = false;
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
        if (paused == true)
        {
            Pause();
        }
        else if (paused == false)
        {
            UnPause();
        }
    }

    void OnMouseDown()
    {
        paused = !paused;  //toggles with each click
    }

    private void Pause()
    {
        pausemessage.gameObject.SetActive(true);
        //pausebutton.gameObject.SetActive(false);
        shield.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void UnPause()
    {
        pausemessage.gameObject.SetActive(false);
        //pausebutton.gameObject.SetActive(true);
        shield.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
