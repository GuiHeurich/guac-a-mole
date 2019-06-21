using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissedClicked : MonoBehaviour
{
    public new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnMouseDown()
    {
        GameControlScript.life -= 1;
        audio.PlayOneShot(audio.clip);

    }
}
